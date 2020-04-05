using System;

namespace Datapoint.Globalization
{
	/// <inheritdoc />
	public sealed class DateTimeFormatter : IDateTimeFormatter
	{
		/// <inheritdoc />
		public string FormatDate(ILocale locale, DateTime moment) =>

			moment.ToString("D", locale.Culture.DateTimeFormat);

		/// <inheritdoc />
		public string FormatDateTime(ILocale locale, DateTime moment) =>

			moment.ToString("F", locale.Culture.DateTimeFormat);

		/// <inheritdoc />
		public string FormatShortDate(ILocale locale, DateTime moment) =>

			moment.ToString("d", locale.Culture.DateTimeFormat);

		/// <inheritdoc />
		public string FormatShortDateTime(ILocale locale, DateTime moment) =>

			moment.ToString("f", locale.Culture.DateTimeFormat);

		/// <inheritdoc />
		public string FormatShortTime(ILocale locale, DateTime moment) =>

			moment.ToString("t", locale.Culture.DateTimeFormat);

		/// <inheritdoc />
		public string FormatShortTime(ILocale locale, TimeSpan moment) =>

			moment.ToString("t", locale.Culture.DateTimeFormat);

		/// <inheritdoc />
		public string FormatTime(ILocale locale, DateTime moment) =>

			moment.ToString("T", locale.Culture.DateTimeFormat);

		/// <inheritdoc />
		public string FormatTime(ILocale locale, TimeSpan moment) =>

			moment.ToString("T", locale.Culture.DateTimeFormat);
	}
}
