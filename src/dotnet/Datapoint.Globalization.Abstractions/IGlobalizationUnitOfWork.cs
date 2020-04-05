namespace Datapoint.Globalization
{
	/// <summary>
	///		A globalization unit of work.
	/// </summary>
	public interface IGlobalizationUnitOfWork
	{
		/// <summary>
		///		Gets the currency repository.
		/// </summary>
		public ICurrencyRepository Currencies { get; }

		/// <summary>
		///		Gets the locale repository.
		/// </summary>
		public ILocaleRepository Locales { get; }

		/// <summary>
		///		Gets the message repository.
		/// </summary>
		public IMessageRepository Messages { get; }

		/// <summary>
		///		Gets a globalization context.
		/// </summary>
		/// <exception cref="Datapoint.Globalization.LocaleFactoryException">
		///		Thrown when an unexpected error is encountered while creating
		///		the repository population.
		/// </exception>
		/// <exception cref="Datapoint.Globalization.LocaleNotFoundException">
		///		Thrown when the locale is not found.
		/// </exception>
		/// <param name="locale">
		///		The locale to get the globalization context for.
		/// </param>
		/// <param name="domain">
		///		The domain to get the globalization context for.
		/// </param>
		/// <returns>
		///		The globalization context.
		/// </returns>
		IGlobalizationContext CreateContext(string locale, string domain);
	}
}
