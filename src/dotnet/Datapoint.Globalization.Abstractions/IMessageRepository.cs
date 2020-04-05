using System.Collections.Generic;

namespace Datapoint.Globalization
{
	/// <summary>
	///		Gives read-only access to a collection of message translations
	///		created through a specific factory implementation.
	/// </summary>
	public interface IMessageRepository
	{
		/// <summary>
		///		Gets a message translation.
		///		
		///		If a translation is not found matching the locale and domain, 
		///		the original message is returned in its place.
		/// </summary>
		/// <exception cref="Datapoint.Globalization.MessageFactoryException">
		///		Thrown when an unexpected error is encountered while creating
		///		the repository population.
		///	</exception>
		/// <param name="locale">
		///		The message locale.
		/// </param>
		/// <param name="domain">
		///		The message domain.
		/// </param>
		/// <param name="message">
		///		The message.
		/// </param>
		/// <returns>
		///		The message translation.
		/// </returns>
		string GetMessage(ILocale locale, string domain, string message);

		/// <summary>
		///		Gets the message translations for a specific locale and domain.
		/// </summary>
		/// <exception cref="Datapoint.Globalization.MessageFactoryException">
		///		Thrown when an unexpected error is encountered while creating
		///		the repository population.
		///	</exception>
		/// <param name="locale">
		///		The messages locale.
		///	</param>
		/// <param name="domain">
		///		The messages domain.
		///	</param>
		/// <returns>
		///		The messages translation.
		/// </returns>
		IReadOnlyDictionary<string, string> GetMessages(ILocale locale, string domain);
	}
}
