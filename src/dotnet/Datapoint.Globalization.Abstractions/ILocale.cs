using System.Globalization;

namespace Datapoint.Globalization
{
	public interface ILocale
	{
		/// <summary>
		///		Gets the culture information.
		/// </summary>
		CultureInfo Culture { get; }

		/// <summary>
		///		Gets the region information.
		/// </summary>
		RegionInfo Region { get; }
	}
}
