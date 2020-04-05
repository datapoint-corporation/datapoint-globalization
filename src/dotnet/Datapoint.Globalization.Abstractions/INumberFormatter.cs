namespace Datapoint.Globalization
{
	/// <summary>
	///		A number formatter.
	/// </summary>
	public interface INumberFormatter
	{
		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="locale">
		///		The locale to format number for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(ILocale locale, decimal amount);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="locale">
		///		The locale to format number for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(ILocale locale, decimal amount, int scale);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="locale">
		///		The locale to format number for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(ILocale locale, double amount);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="locale">
		///		The locale to format number for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(ILocale locale, double amount, int scale);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="locale">
		///		The locale to format number for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(ILocale locale, float amount);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="locale">
		///		The locale to format number for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(ILocale locale, float amount, int scale);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="locale">
		///		The locale to format number for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(ILocale locale, int amount);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="locale">
		///		The locale to format number for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(ILocale locale, int amount, int scale);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="locale">
		///		The locale to format number for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(ILocale locale, long amount);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="locale">
		///		The locale to format number for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(ILocale locale, long amount, int scale);
	}
}