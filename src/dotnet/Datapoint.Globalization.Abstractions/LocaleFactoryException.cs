using System;

namespace Datapoint.Globalization
{
	public class LocaleFactoryException : Exception
	{
		public LocaleFactoryException(ILocaleFactory localeFactory)
		{
			LocaleFactory = localeFactory ?? throw new ArgumentNullException(nameof(localeFactory));
		}

		public LocaleFactoryException(ILocaleFactory localeFactory, string? message) : base(message)
		{
			LocaleFactory = localeFactory ?? throw new ArgumentNullException(nameof(localeFactory));
		}

		public LocaleFactoryException(ILocaleFactory localeFactory, string? message, Exception? innerException) : base(message, innerException)
		{
			LocaleFactory = localeFactory ?? throw new ArgumentNullException(nameof(localeFactory));
		}

		public ILocaleFactory LocaleFactory { get; }
	}
}
