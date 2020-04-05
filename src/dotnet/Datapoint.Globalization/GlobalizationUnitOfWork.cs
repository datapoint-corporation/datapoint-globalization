using System;

namespace Datapoint.Globalization
{
	/// <inheritdoc />
	public sealed class GlobalizationUnitOfWork : IGlobalizationUnitOfWork
	{
		/// <summary>
		///		Creates a new globalization unit of work.
		/// </summary>
		/// <param name="currencies">
		///		The currency repository.
		/// </param>
		/// <param name="locales">
		///		The locale repository.
		/// </param>
		/// <param name="messages">
		///		The message repository.
		/// </param>
		public GlobalizationUnitOfWork(ICurrencyRepository currencies, ILocaleRepository locales, IMessageRepository messages)
		{
			Currencies = currencies ?? throw new ArgumentNullException(nameof(currencies));
			Locales = locales ?? throw new ArgumentNullException(nameof(locales));
			Messages = messages ?? throw new ArgumentNullException(nameof(messages));
		}

		/// <inheritdoc />
		public ICurrencyRepository Currencies { get; }

		/// <inheritdoc />
		public ILocaleRepository Locales { get; }

		/// <inheritdoc />
		public IMessageRepository Messages { get; }

		/// <inheritdoc />
		public IGlobalizationContext CreateContext(string locale, string domain)
		{
			return new GlobalizationContext
			(
				Locales.GetLocale(locale),
				domain,
				Currencies,
				Messages
			);
		}
	}
}
