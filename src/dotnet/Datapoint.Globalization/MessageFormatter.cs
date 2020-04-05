namespace Datapoint.Globalization
{
	/// <inheritdoc />
	public sealed class MessageFormatter : IMessageFormatter
	{
		/// <inheritdoc />
		public string FormatMessage(ILocale locale, string message, params object[] arguments) =>

			string.Format(locale.Culture, message, arguments);
	}
}
