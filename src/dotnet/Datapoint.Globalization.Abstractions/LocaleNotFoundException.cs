using System;

namespace Datapoint.Globalization
{
	/// <summary>
	///		Thrown when a specific locale is not found.
	/// </summary>
	[Serializable]
	public class LocaleNotFoundException : Exception
	{
		public LocaleNotFoundException()
		{
		}

		public LocaleNotFoundException(string? message) : base(message)
		{
		}

		public LocaleNotFoundException(string? message, Exception? innerException) : base(message, innerException)
		{
		}
	}
}
