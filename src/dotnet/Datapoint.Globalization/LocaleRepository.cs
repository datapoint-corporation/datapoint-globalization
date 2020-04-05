using System;
using System.Collections.Generic;
using System.Linq;

namespace Datapoint.Globalization
{
	/// <inheritdoc />
	public sealed class LocaleRepository : ILocaleRepository
	{
		/// <summary>
		///		The locale factory.
		/// </summary>
		private readonly ILocaleFactory _factory;

		/// <summary>
		///		The locales, by culture name.
		/// </summary>
		private Dictionary<string, ILocale>? _locales;

		/// <summary>
		///		Creates a new locale repository.
		/// </summary>
		/// <param name="factory">
		///		The locale factory.
		/// </param>
		public LocaleRepository(ILocaleFactory factory)
		{
			_factory = factory ?? throw new ArgumentNullException(nameof(factory));
		}

		/// <inheritdoc />
		public ILocale GetLocale(string locale)
		{
			if (!GetLocalesWithCache().TryGetValue(locale, out var instance))
				throw new LocaleNotFoundException($"Locale \"{locale}\" was not found.");

			return instance;
		}

		/// <inheritdoc />
		public ILocale[] GetLocales() =>

			GetLocalesWithCache().Values.ToArray();

		/// <summary>
		///		Makes an attempt to get the locales from cache delegating
		///		its initial population to the factory.
		/// </summary>
		/// <exception cref="Datapoint.Globalization.LocaleFactoryException">
		///		Thrown when an unexpected error is encountered while creating
		///		the repository population.
		/// </exception>
		/// <returns>
		///		The locales, by culture name.
		/// </returns>
		private Dictionary<string, ILocale> GetLocalesWithCache()
		{
			if (_locales == null)
			{
				var locales = new Dictionary<string, ILocale>();

				try
				{
					foreach (var locale in _factory.CreateLocales())
						if (!locales.TryAdd(locale.Culture.Name, locale))
							throw new Exception($"Locale \"{locale.Culture.Name}\" was created by the factory more than once.");
				}
				catch (Exception e)
				{
					throw new LocaleFactoryException
					(
						_factory,
						"An exception was caught while trying to create the locale repository population.",
						e
					);
				}

				_locales = locales;
			}

			return _locales;
		}
	}
}
