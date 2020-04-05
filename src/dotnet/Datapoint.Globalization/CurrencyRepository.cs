using System;
using System.Collections.Generic;
using System.Linq;

namespace Datapoint.Globalization
{
	/// <inheritdoc />
	public sealed class CurrencyRepository : ICurrencyRepository
	{
		/// <summary>
		///		The currency factory.
		/// </summary>
		private readonly ICurrencyFactory _factory;

		/// <summary>
		///		The currency instances.
		/// </summary>
		private Dictionary<string, ICurrency>? _currencies = null;

		/// <summary>
		///		Creates a new currency repository.
		/// </summary>
		/// <param name="factory">
		///		The currency factory.
		/// </param>
		public CurrencyRepository(ICurrencyFactory factory)
		{
			_factory = factory ?? throw new ArgumentNullException(nameof(factory));
		}

		/// <inheritdoc />
		public ICurrency[] GetCurrencies() =>

			GetCurrenciesWithCache().Values.ToArray();

		/// <summary>
		///		Makes an attempt to get the currencies from cache delegating
		///		its initial population to the factory.
		/// </summary>
		/// <exception cref="Datapoint.Globalization.CurrencyFactoryException">
		///		Thrown when an unexpected error is encountered while creating
		///		the repository population.
		/// </exception>
		/// <returns>
		///		The currencies, by code.
		/// </returns>
		private Dictionary<string, ICurrency> GetCurrenciesWithCache()
		{
			if (_currencies == null)
			{
				var currencies = new Dictionary<string, ICurrency>();

				try
				{
					foreach (var currency in _factory.CreateCurrencies())
						if (!currencies.TryAdd(currency.Code, currency))
							throw new Exception($"Currency '{currency.Code}' was created by the factory more than once.");
				}
				catch (Exception e)
				{
					throw new CurrencyFactoryException
					(
						_factory,
						"An exception was caught while trying to create the currency repository population.",
						e
					);
				}


				_currencies = currencies;
			}

			return _currencies;
		}

		/// <inheritdoc />
		public ICurrency GetCurrency(string currency)
		{
			if (!GetCurrenciesWithCache().TryGetValue(currency, out var instance))
				throw new CurrencyNotFoundException($"Currency '{currency}' was not found.");

			return instance;
		}

		/// <inheritdoc />
		public ICurrency GetDefaultCurrency(ILocale locale) =>

			GetCurrency(locale.Region.ISOCurrencySymbol);
	}
}
