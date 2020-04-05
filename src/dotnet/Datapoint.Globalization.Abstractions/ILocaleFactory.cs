using System.Collections.Generic;

namespace Datapoint.Globalization
{
	public interface ILocaleFactory
	{
		/// <summary>
		///		Creates the locales.
		/// </summary>
		/// <returns>
		///		The locales.
		/// </returns>
		IEnumerable<ILocale> CreateLocales();
	}
}
