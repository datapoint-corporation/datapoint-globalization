using System;

namespace Datapoint.Globalization
{
	/// <inheritdoc />
	public sealed class NumberFormatter : INumberFormatter
	{
		/// <inheritdoc />
		public string FormatNumber(ILocale locale, decimal amount) =>

			amount.ToString("N", locale.Culture.NumberFormat);

		/// <inheritdoc />
		public string FormatNumber(ILocale locale, decimal amount, int scale)
		{
			if (scale < 0)
				throw new ArgumentOutOfRangeException(nameof(scale));

			return amount.ToString($"N{scale}", locale.Culture.NumberFormat);
		}

		/// <inheritdoc />
		public string FormatNumber(ILocale locale, double amount) =>

			amount.ToString("N", locale.Culture.NumberFormat);

		/// <inheritdoc />
		public string FormatNumber(ILocale locale, double amount, int scale)
		{
			if (scale < 0)
				throw new ArgumentOutOfRangeException(nameof(scale));

			return amount.ToString($"N{scale}", locale.Culture.NumberFormat);
		}

		/// <inheritdoc />
		public string FormatNumber(ILocale locale, float amount) =>

			amount.ToString("N", locale.Culture.NumberFormat);

		/// <inheritdoc />
		public string FormatNumber(ILocale locale, float amount, int scale)
		{
			if (scale < 0)
				throw new ArgumentOutOfRangeException(nameof(scale));

			return amount.ToString($"N{scale}", locale.Culture.NumberFormat);
		}

		/// <inheritdoc />
		public string FormatNumber(ILocale locale, int amount) =>

			amount.ToString("N", locale.Culture.NumberFormat);

		/// <inheritdoc />
		public string FormatNumber(ILocale locale, int amount, int scale)
		{
			if (scale < 0)
				throw new ArgumentOutOfRangeException(nameof(scale));

			return amount.ToString($"N{scale}", locale.Culture.NumberFormat);
		}

		/// <inheritdoc />
		public string FormatNumber(ILocale locale, long amount) =>

			amount.ToString("N", locale.Culture.NumberFormat);

		/// <inheritdoc />
		public string FormatNumber(ILocale locale, long amount, int scale)
		{
			if (scale < 0)
				throw new ArgumentOutOfRangeException(nameof(scale));

			return amount.ToString($"N{scale}", locale.Culture.NumberFormat);
		}
	}
}
