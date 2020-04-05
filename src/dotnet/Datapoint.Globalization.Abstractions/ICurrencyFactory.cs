using System.Collections.Generic;

namespace Datapoint.Globalization
{
	public interface ICurrencyFactory
	{
		/// <summary>
		///		Creates the currencies.
		/// </summary>
		/// <returns>
		///		The currencies.
		/// </returns>
		IEnumerable<ICurrency> CreateCurrencies();
	}
}
