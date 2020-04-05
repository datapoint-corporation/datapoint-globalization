using System.Collections.Generic;
using System.Globalization;

namespace Datapoint.Globalization.Environment
{
	/// <inheritdoc />
	public sealed class EnvironmentCurrencyFactory : ICurrencyFactory
	{
		/// <inheritdoc />
		public IEnumerable<ICurrency> CreateCurrencies()
		{
			var hashSet = new HashSet<string>();

			foreach (var culture in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
			{
				var region = new RegionInfo(culture.Name);

				if (string.IsNullOrEmpty(culture.NumberFormat.CurrencySymbol))
					continue;

				if (string.IsNullOrEmpty(region.ISOCurrencySymbol))
					continue;

				if (hashSet.Contains(region.ISOCurrencySymbol))
					continue;

				hashSet.Add(region.ISOCurrencySymbol);

				yield return new Currency
				(
					region.ISOCurrencySymbol,
					culture.NumberFormat.CurrencyDecimalDigits,
					culture.NumberFormat.CurrencySymbol
				);
			}
		}
	}
}
