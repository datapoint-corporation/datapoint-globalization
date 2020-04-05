using System;

namespace Datapoint.Globalization
{
	public sealed class CurrencyFactoryException : Exception
	{
		public CurrencyFactoryException(ICurrencyFactory currencyFactory)
		{
			CurrencyFactory = currencyFactory ?? throw new ArgumentNullException(nameof(currencyFactory));
		}

		public CurrencyFactoryException(ICurrencyFactory currencyFactory, string? message) : base(message)
		{
			CurrencyFactory = currencyFactory ?? throw new ArgumentNullException(nameof(currencyFactory));
		}

		public CurrencyFactoryException(ICurrencyFactory currencyFactory, string? message, Exception? innerException) : base(message, innerException)
		{
			CurrencyFactory = currencyFactory ?? throw new ArgumentNullException(nameof(currencyFactory));
		}

		public ICurrencyFactory CurrencyFactory { get; }
	}
}
