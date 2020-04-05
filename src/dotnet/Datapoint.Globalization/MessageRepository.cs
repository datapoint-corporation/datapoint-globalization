using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace Datapoint.Globalization
{
	/// <inheritdoc />
	public sealed class MessageRepository : IMessageRepository
	{
		/// <summary>
		///		The message factory.
		/// </summary>
		private readonly IMessageFactory _factory;

		/// <summary>
		///		The messages, by locale and then domain.
		/// </summary>
		private readonly Dictionary<ILocale, Dictionary<string, Dictionary<string, string>>> _messages = new Dictionary<ILocale, Dictionary<string, Dictionary<string, string>>>();

		/// <summary>
		///		Creates a new message repository.
		/// </summary>
		/// <param name="factory">
		///		The message factory.
		/// </param>
		public MessageRepository(IMessageFactory factory)
		{
			_factory = factory ?? throw new ArgumentNullException(nameof(factory));
		}


		/// <inheritdoc />
		[SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "Clarity")]
		public string GetMessage(ILocale locale, string domain, string message)
		{
			if (!GetMessagesWithCache(locale, domain).TryGetValue(message, out var translation))
				return message;

			return translation;
		}

		/// <inheritdoc />
		public IReadOnlyDictionary<string, string> GetMessages(ILocale locale, string domain) =>

			new ReadOnlyDictionary<string, string>(GetMessagesWithCache(locale, domain));

		/// <summary>
		///		Makes an attempt to get the message translations from cache 
		///		delegating its initial population to the factory.
		/// </summary>
		/// <exception cref="Datapoint.Globalization.MessageFactoryException">
		///		Thrown when an unexpected error is encountered while creating
		///		the repository population.
		///	</exception>
		/// <param name="locale">
		///		The locale to get the message translations for.
		/// </param>
		/// <param name="domain">
		///		The domain to get the message translations for.
		/// </param>
		/// <returns>
		///		The message translations, by message.
		/// </returns>
		private Dictionary<string, string> GetMessagesWithCache(ILocale locale, string domain)
		{
			if (!_messages.TryGetValue(locale, out var localeDomainsMessages))
			{
				_messages.Add
				(
					locale,
					localeDomainsMessages = new Dictionary<string, Dictionary<string, string>>()
				);
			}

			if (!localeDomainsMessages.TryGetValue(domain, out var localeDomainMessages))
			{
				var messages = new Dictionary<string, string>();

				try
				{
					foreach (var message in _factory.CreateMessages(locale, domain))
						if (!messages.TryAdd(message.Key, message.Value))
							throw new Exception($"Message '{message.Key}' was created by the factory more than once.");
				}
				catch (Exception e)
				{
					throw new MessageFactoryException
					(
						_factory,
						"An exception was caught while trying to create the message repository population.",
						e
					);
				}

				localeDomainsMessages.Add
				(
					domain,
					localeDomainMessages = messages
				);
			}

			return localeDomainMessages;
		}
	}
}
