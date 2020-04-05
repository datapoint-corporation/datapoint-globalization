namespace Datapoint.Globalization
{
	/// <summary>
	///		Gives read-only access to a collection of currencies created 
	///		through a specific factory implementation.
	/// </summary>
	public interface ICurrencyRepository
	{
		/// <summary>
		///		Gets all currencies.
		/// </summary>
		/// <exception cref="Datapoint.Globalization.CurrencyFactoryException">
		///		Thrown when an unexpected error is encountered while creating
		///		the repository population.
		/// </exception>
		/// <returns>
		///		The currencies.
		/// </returns>
		ICurrency[] GetCurrencies();

		/// <summary>
		///		Gets a currency.
		/// </summary>
		/// <exception cref="Datapoint.Globalization.CurrencyFactoryException">
		///		Thrown when an unexpected error is encountered while creating
		///		the repository population.
		/// </exception>
		///	<exception cref="Datapoint.Globalization.CurrencyNotFoundException">
		///		Thrown when the currency is not found.
		///	</exception>
		/// <param name="currency">
		///		The currency code.
		///	</param>
		/// <returns>
		///		The currency.
		/// </returns>
		ICurrency GetCurrency(string currency);

		/// <summary>
		///		Gets the default currency for a specific locale.
		/// </summary>
		/// <exception cref="Datapoint.Globalization.CurrencyFactoryException">
		///		Thrown when an unexpected error is encountered while creating
		///		the repository population.
		/// </exception>
		///	<exception cref="Datapoint.Globalization.CurrencyNotFoundException">
		///		Thrown when the currency is not found.
		///	</exception>
		/// <param name="locale">
		///		The locale to get the default currency for.
		/// </param>
		/// <returns>
		///		The currency.
		/// </returns>
		ICurrency GetDefaultCurrency(ILocale locale);
	}
}
