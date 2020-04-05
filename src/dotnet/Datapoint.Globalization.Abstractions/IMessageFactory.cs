using System.Collections.Generic;

namespace Datapoint.Globalization
{
	/// <summary>
	///		A message factory.
	/// </summary>
	public interface IMessageFactory
	{
		/// <summary>
		///		Creates the messages for a specific locale and domain.
		/// </summary>
		/// <param name="locale">
		///		The locale to create the messages from.
		/// </param>
		/// <param name="domain">
		///		The domain to create the messages from.
		/// </param>
		/// <returns>
		///		The messages translation.
		/// </returns>
		IEnumerable<KeyValuePair<string, string>> CreateMessages(ILocale locale, string domain);
	}
}
