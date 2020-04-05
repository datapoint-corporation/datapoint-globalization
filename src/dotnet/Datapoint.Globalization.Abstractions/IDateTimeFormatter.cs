using System;

namespace Datapoint.Globalization
{
	/// <summary>
	///		A date and time formatter.
	/// </summary>
	public interface IDateTimeFormatter
	{
		/// <summary>
		///		Formats a moment into a short date string.
		/// </summary>
		/// <param name="locale">
		///		The locale to format for.
		///	</param>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatShortDate(ILocale locale, DateTime moment);

		/// <summary>
		///		Formats a moment into a short date and time string.
		/// </summary>
		/// <param name="locale">
		///		The locale to format for.
		///	</param>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatShortDateTime(ILocale locale, DateTime moment);

		/// <summary>
		///		Formats a moment into a short time string.
		/// </summary>
		/// <param name="locale">
		///		The locale to format for.
		///	</param>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatShortTime(ILocale locale, DateTime moment);

		/// <summary>
		///		Formats a moment into a short time string.
		/// </summary>
		/// <param name="locale">
		///		The locale to format for.
		///	</param>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatShortTime(ILocale locale, TimeSpan moment);

		/// <summary>
		///		Formats a moment into a date string.
		/// </summary>
		/// <param name="locale">
		///		The locale to format for.
		///	</param>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatDate(ILocale locale, DateTime moment);

		/// <summary>
		///		Formats a moment into a date and time string.
		/// </summary>
		/// <param name="locale">
		///		The locale to format for.
		///	</param>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatDateTime(ILocale locale, DateTime moment);

		/// <summary>
		///		Formats a moment into a time string.
		/// </summary>
		/// <param name="locale">
		///		The locale to format for.
		///	</param>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatTime(ILocale locale, DateTime moment);

		/// <summary>
		///		Formats a moment into a time string.
		/// </summary>
		/// <param name="locale">
		///		The locale to format for.
		///	</param>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatTime(ILocale locale, TimeSpan moment);
	}
}