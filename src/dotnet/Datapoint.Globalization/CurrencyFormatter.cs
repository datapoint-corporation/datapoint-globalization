using System;
using System.Globalization;

namespace Datapoint.Globalization
{
	/// <inheritdoc />
	public sealed class CurrencyFormatter : ICurrencyFormatter
	{
		/// <summary>
		///		Creates the number format information.
		/// </summary>
		/// <param name="locale">
		///		The locale to create the number format information for.
		/// </param>
		/// <param name="currency">
		///		The currency to create the number format information for.
		/// </param>
		/// <returns>
		///		The number format information.
		/// </returns>
		private NumberFormatInfo CreateNumberFormatInfo(ILocale locale, ICurrency currency)
		{
			if (currency.Code.Equals(locale.Region.ISOCurrencySymbol))
				return locale.Culture.NumberFormat;

			var nfi = (NumberFormatInfo)locale.Culture.NumberFormat.Clone();
			nfi.CurrencySymbol = currency.Symbol ?? currency.Code;
			nfi.CurrencyDecimalDigits = currency.Scale;

			return nfi;
		}

		/// <inheritdoc />
		public string FormatCurrency(ILocale locale, ICurrency currency, decimal amount) =>

			amount.ToString("C", CreateNumberFormatInfo(locale, currency));

		/// <inheritdoc />
		public string FormatCurrency(ILocale locale, ICurrency currency, decimal amount, int scale)
		{
			if (scale < 0)
				throw new ArgumentOutOfRangeException(nameof(scale));

			return amount.ToString($"C{scale}", CreateNumberFormatInfo(locale, currency));
		}

		/// <inheritdoc />
		public string FormatCurrency(ILocale locale, ICurrency currency, double amount) =>

			amount.ToString("C", CreateNumberFormatInfo(locale, currency));

		/// <inheritdoc />
		public string FormatCurrency(ILocale locale, ICurrency currency, double amount, int scale)
		{
			if (scale < 0)
				throw new ArgumentOutOfRangeException(nameof(scale));

			return amount.ToString($"C{scale}", CreateNumberFormatInfo(locale, currency));
		}

		/// <inheritdoc />
		public string FormatCurrency(ILocale locale, ICurrency currency, float amount) =>

			amount.ToString("C", CreateNumberFormatInfo(locale, currency));

		/// <inheritdoc />
		public string FormatCurrency(ILocale locale, ICurrency currency, float amount, int scale)
		{
			if (scale < 0)
				throw new ArgumentOutOfRangeException(nameof(scale));

			return amount.ToString($"C{scale}", CreateNumberFormatInfo(locale, currency));
		}

		/// <inheritdoc />
		public string FormatCurrency(ILocale locale, ICurrency currency, int amount) =>

			amount.ToString("C", CreateNumberFormatInfo(locale, currency));

		/// <inheritdoc />
		public string FormatCurrency(ILocale locale, ICurrency currency, int amount, int scale)
		{
			if (scale < 0)
				throw new ArgumentOutOfRangeException(nameof(scale));

			return amount.ToString($"C{scale}", CreateNumberFormatInfo(locale, currency));
		}

		/// <inheritdoc />
		public string FormatCurrency(ILocale locale, ICurrency currency, long amount) =>

			amount.ToString("C", CreateNumberFormatInfo(locale, currency));

		/// <inheritdoc />
		public string FormatCurrency(ILocale locale, ICurrency currency, long amount, int scale)
		{
			if (scale < 0)
				throw new ArgumentOutOfRangeException(nameof(scale));

			return amount.ToString($"C{scale}", CreateNumberFormatInfo(locale, currency));
		}
	}
}
