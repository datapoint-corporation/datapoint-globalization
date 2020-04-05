using System;
using System.Collections.Generic;

namespace Datapoint.Globalization
{
	/// <summary>
	///		A globalization context is tied to a specific locale and domain,
	///		providing easy access to currency, message and number formatting
	///		and translation services.
	/// </summary>
	public interface IGlobalizationContext
	{
		/// <summary>
		///		Gets the global unique identifier.
		/// </summary>
		Guid Guid { get; }

		/// <summary>
		///		Gets the locale.
		/// </summary>
		ILocale Locale { get; }

		/// <summary>
		///		Gets the domain.
		/// </summary>
		string Domain { get; }

		#region Currency formatting

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(decimal amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ICurrency currency, decimal amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(decimal amount, int scale);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ICurrency currency, decimal amount, int scale);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(double amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ICurrency currency, double amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(double amount, int scale);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ICurrency currency, double amount, int scale);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(float amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ICurrency currency, float amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(float amount, int scale);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ICurrency currency, float amount, int scale);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(int amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ICurrency currency, int amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(int amount, int scale);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ICurrency currency, int amount, int scale);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(long amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ICurrency currency, long amount);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(long amount, int scale);

		/// <summary>
		///		Formats a currency.
		/// </summary>
		/// <param name="currency">
		///		The currency to format for.
		/// </param>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The post-format amount.
		/// </returns>
		string FormatCurrency(ICurrency currency, long amount, int scale);

		#endregion

		#region Date and time formatting

		/// <summary>
		///		Formats a moment into a short date string.
		/// </summary>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatShortDate(DateTime moment);

		/// <summary>
		///		Formats a moment into a short date and time string.
		/// </summary>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatShortDateTime(DateTime moment);

		/// <summary>
		///		Formats a moment into a short time string.
		/// </summary>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatShortTime(DateTime moment);

		/// <summary>
		///		Formats a moment into a short time string.
		/// </summary>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatShortTime(TimeSpan moment);

		/// <summary>
		///		Formats a moment into a date string.
		/// </summary>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatDate(DateTime moment);

		/// <summary>
		///		Formats a moment into a date and time string.
		/// </summary>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatDateTime(DateTime moment);

		/// <summary>
		///		Formats a moment into a time string.
		/// </summary>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatTime(DateTime moment);

		/// <summary>
		///		Formats a moment into a time string.
		/// </summary>
		/// <param name="moment">
		///		The moment to format.
		/// </param>
		/// <returns>
		///		The moment, post-format.
		/// </returns>
		string FormatTime(TimeSpan moment);

		#endregion

		#region Message formatting

		/// <summary>
		///		Formats a message.
		///		
		///		If a translation is available for the given message, it is
		///		applied before the actual formatting procedure takes place.
		/// </summary>
		/// <exception cref="Datapoint.Globalization.MessageFactoryException">
		///		Thrown when an unexpected error is encountered while creating
		///		the repository population.
		///	</exception>
		/// <param name="message">The message to format.</param>
		/// <param name="arguments">The arguments to format with.</param>
		/// <returns>The message, post-format.</returns>
		public string FormatMessage(string message, params object[] arguments);

		#endregion

		#region Number formatting

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(decimal amount);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(decimal amount, int scale);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(double amount);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(double amount, int scale);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(float amount);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(float amount, int scale);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(int amount);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(int amount, int scale);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(long amount);

		/// <summary>
		///		Formats a number.
		/// </summary>
		/// <param name="amount">
		///		The amount to format.
		/// </param>
		/// <param name="scale">
		///		The number of decimal digits to format for.
		/// </param>
		/// <returns>
		///		The amount, post-format.
		/// </returns>
		string FormatNumber(long amount, int scale);

		#endregion

		/// <summary>
		///		Gets the default currency for this locale.
		/// </summary>
		/// <exception cref="Datapoint.Globalization.CurrencyFactoryException">
		///		Thrown when an unexpected error is encountered while creating
		///		the repository population.
		/// </exception>
		///	<exception cref="Datapoint.Globalization.CurrencyNotFoundException">
		///		Thrown when the currency is not found.
		///	</exception>
		/// <returns>
		///		The currency.
		/// </returns>
		ICurrency GetDefaultCurrency();

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
		/// <param name="message">
		///		The message.
		/// </param>
		/// <returns>
		///		The message translation.
		/// </returns>
		string GetMessage(string message);

		/// <summary>
		///		Gets the message translations for a specific locale and domain.
		/// </summary>
		/// <exception cref="Datapoint.Globalization.MessageFactoryException">
		///		Thrown when an unexpected error is encountered while creating
		///		the repository population.
		///	</exception>
		/// <returns>
		///		The messages translation.
		/// </returns>
		IReadOnlyDictionary<string, string> GetMessages();
	}
}
