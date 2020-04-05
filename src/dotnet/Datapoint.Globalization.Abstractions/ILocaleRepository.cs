namespace Datapoint.Globalization
{
	/// <summary>
	///		Gives read-only access to a collection of locales created through
	///		a specific factory implementation.
	/// </summary>
	public interface ILocaleRepository
	{
		/// <summary>
		///		Gets a locale.
		/// </summary>
		/// <exception cref="Datapoint.Globalization.LocaleFactoryException">
		///		Thrown when an unexpected error is encountered while creating
		///		the repository population.
		/// </exception>
		/// <exception cref="Datapoint.Globalization.LocaleNotFoundException">
		///		Thrown when the locale is not found.
		/// </exception>
		/// <param name="locale">
		///		The locale name.
		/// </param>
		/// <returns>
		///		The locale.
		/// </returns>
		ILocale GetLocale(string locale);

		/// <summary>
		///		Gets all locales.
		/// </summary>
		/// <exception cref="Datapoint.Globalization.LocaleFactoryException">
		///		Thrown when an unexpected error is encountered while creating
		///		the repository population.
		/// </exception>
		/// <returns>
		///		The locales.
		/// </returns>
		ILocale[] GetLocales();
	}
}
