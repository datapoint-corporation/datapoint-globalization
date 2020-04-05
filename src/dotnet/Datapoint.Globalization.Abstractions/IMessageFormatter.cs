namespace Datapoint.Globalization
{
	/// <summary>
	///		A message formatter.
	/// </summary>
	public interface IMessageFormatter
	{
		/// <summary>
		///		Formats a message.
		/// </summary>
		/// <param name="locale">The locale to format the message for.</param>
		/// <param name="message">The message to format.</param>
		/// <param name="arguments">The arguments to format with.</param>
		/// <returns>The message, post-format.</returns>
		string FormatMessage(ILocale locale, string message, params object[] arguments);
	}
}
