namespace Datapoint.Globalization
{
	/// <summary>
	///		A currency formatter.
	/// </summary>
	public interface ICurrencyFormatter
	{
		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="locale">
		///		The locale to format the currency for.
		/// </param>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ILocale locale, ICurrency currency, decimal amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="locale">
		///		The locale to format the currency for.
		/// </param>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ILocale locale, ICurrency currency, decimal amount, int scale);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="locale">
		///		The locale to format the currency for.
		/// </param>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ILocale locale, ICurrency currency, double amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="locale">
		///		The locale to format the currency for.
		/// </param>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ILocale locale, ICurrency currency, double amount, int scale);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="locale">
		///		The locale to format the currency for.
		/// </param>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ILocale locale, ICurrency currency, float amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="locale">
		///		The locale to format the currency for.
		/// </param>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ILocale locale, ICurrency currency, float amount, int scale);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="locale">
		///		The locale to format the currency for.
		/// </param>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ILocale locale, ICurrency currency, int amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="locale">
		///		The locale to format the currency for.
		/// </param>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ILocale locale, ICurrency currency, int amount, int scale);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="locale">
		///		The locale to format the currency for.
		/// </param>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ILocale locale, ICurrency currency, long amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="locale">
		///		The locale to format the currency for.
		/// </param>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ILocale locale, ICurrency currency, long amount, int scale);
	}
}