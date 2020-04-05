namespace Datapoint.Globalization
{
	/// <summary>
	///		A currency.
	/// </summary>
	public interface ICurrency
	{
		/// <summary>
		///		Gets the currency code (ISO 4217).
		/// </summary>
		string Code { get; }

		/// <summary>
		///		Gets the currency scale.
		/// </summary>
		int Scale { get; }

		/// <summary>
		///		Gets the currency symbol.
		/// </summary>
		string? Symbol { get; }
	}
}
