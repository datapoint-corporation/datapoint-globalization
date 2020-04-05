using System;

namespace Datapoint.Globalization
{
	/// <inheritdoc />
	public sealed class Currency : ICurrency
	{
		/// <summary>
		///		Creates a currency.
		/// </summary>
		/// <param name="code">
		///		The currency code (ISO 4217).
		/// </param>
		/// <param name="scale">
		///		The currency scale.
		/// </param>
		/// <param name="symbol">
		///		The currency symbol.
		/// </param>
		public Currency(string code, int scale, string? symbol)
		{
			if (string.IsNullOrEmpty(code))
				throw new ArgumentNullException(nameof(code));

			if (scale < 0)
				throw new ArgumentOutOfRangeException(nameof(scale));

			Code = code;
			Scale = scale;
			Symbol = symbol;
		}

		/// <inheritdoc />
		public string Code { get; }

		/// <inheritdoc />
		public int Scale { get; }

		/// <inheritdoc />
		public string? Symbol { get; }
	}
}
