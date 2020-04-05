using System.Collections.Generic;
using System.Globalization;

namespace Datapoint.Globalization.Environment
{
	/// <inheritdoc />
	public sealed class EnvironmentLocaleFactory : ILocaleFactory
	{
		/// <inheritdoc />
		public IEnumerable<ILocale> CreateLocales()
		{
			foreach (var culture in CultureInfo.GetCultures(CultureTypes.AllCultures))
			{
				if (culture.Equals(CultureInfo.InvariantCulture))
					continue;

				yield return new Locale
				(
					new CultureInfo(culture.Name),
					culture.IsNeutralCulture ? RegionInfo.CurrentRegion : new RegionInfo(culture.Name)
				);
			}
		}
	}
}
