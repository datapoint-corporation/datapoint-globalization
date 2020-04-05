using System;
using System.Collections.Generic;
using System.Globalization;

namespace Datapoint.Globalization
{
	/// <inheritdoc />
	public sealed class Locale : ILocale
	{
		/// <summary>
		///		Creates a new locale.
		/// </summary>
		/// <param name="culture">
		///		The locale culture information.
		///	</param>
		/// <param name="region">
		///		The locale region information.
		///	</param>
		public Locale(CultureInfo culture, RegionInfo region)
		{
			Culture = (CultureInfo)(culture ?? throw new ArgumentNullException(nameof(culture))).Clone();
			Region = region ?? throw new ArgumentNullException(nameof(region));
		}

		/// <inheritdoc />
		public CultureInfo Culture { get; }

		/// <inheritdoc />
		public RegionInfo Region { get; }

		/// <inheritdoc />
		public override bool Equals(object? obj)
		{
			return obj is Locale locale &&
				   EqualityComparer<CultureInfo>.Default.Equals(Culture, locale.Culture) &&
				   EqualityComparer<RegionInfo>.Default.Equals(Region, locale.Region);
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			return HashCode.Combine(Culture, Region);
		}
	}
}
