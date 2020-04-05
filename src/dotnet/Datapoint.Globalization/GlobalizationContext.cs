using System;
using System.Collections.Generic;

namespace Datapoint.Globalization
{
	/// <inheritdoc />
	public sealed class GlobalizationContext : IGlobalizationContext
	{
		/// <summary>
		///		The currency formatter.
		/// </summary>
		private readonly ICurrencyFormatter _currencyFormatter;

		/// <summary>
		///		The currency repository.
		/// </summary>
		private readonly ICurrencyRepository _currencyRepository;

		/// <summary>
		///		The date and time formatter.
		/// </summary>
		private readonly IDateTimeFormatter _dateTimeFormatter;

		/// <summary>
		///		The message formatter.
		/// </summary>
		private readonly IMessageFormatter _messageFormatter;

		/// <summary>
		///		The message repository.
		/// </summary>
		private readonly IMessageRepository _messageRepository;

		/// <summary>
		///		The number formatter.
		/// </summary>
		private readonly INumberFormatter _numberFormatter;

		/// <summary>
		///		Creates a new globalization context.
		/// </summary>
		/// <param name="locale">
		///		The globalization context locale.
		/// </param>
		/// <param name="domain">
		///		The globalization context domain.
		/// </param>
		/// <param name="currencyRepository">
		///		The globalization context currency repository.
		/// </param>
		/// <param name="messageRepository">
		///		The globalization context message repository.
		/// </param>
		internal GlobalizationContext(ILocale locale, string domain, ICurrencyRepository currencyRepository, IMessageRepository messageRepository)
		{
			Locale = locale ?? throw new ArgumentNullException(nameof(locale));
			Domain = domain ?? throw new ArgumentNullException(nameof(domain));

			_currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
			_messageRepository = messageRepository ?? throw new ArgumentNullException(nameof(messageRepository));

			_currencyFormatter = new CurrencyFormatter();
			_dateTimeFormatter = new DateTimeFormatter();
			_messageFormatter = new MessageFormatter();
			_numberFormatter = new NumberFormatter();
		}

		/// <inheritdoc />
		public Guid Guid { get; } = Guid.NewGuid();

		/// <inheritdoc />
		public ILocale Locale { get; }

		/// <inheritdoc />
		public string Domain { get; }

		#region Currency formatting

		/// <inheritdoc />
		public string FormatCurrency(decimal amount) =>

			_currencyFormatter.FormatCurrency(Locale, GetDefaultCurrency(), amount);

		/// <inheritdoc />
		public string FormatCurrency(ICurrency currency, decimal amount) =>

			_currencyFormatter.FormatCurrency(Locale, currency, amount);

		/// <inheritdoc />
		public string FormatCurrency(decimal amount, int scale) =>

			_currencyFormatter.FormatCurrency(Locale, GetDefaultCurrency(), amount, scale);

		/// <inheritdoc />
		public string FormatCurrency(ICurrency currency, decimal amount, int scale) =>

			_currencyFormatter.FormatCurrency(Locale, currency, amount, scale);

		/// <inheritdoc />
		public string FormatCurrency(double amount) =>

			_currencyFormatter.FormatCurrency(Locale, GetDefaultCurrency(), amount);

		/// <inheritdoc />
		public string FormatCurrency(ICurrency currency, double amount) =>

			_currencyFormatter.FormatCurrency(Locale, currency, amount);

		/// <inheritdoc />
		public string FormatCurrency(double amount, int scale) =>

			_currencyFormatter.FormatCurrency(Locale, GetDefaultCurrency(), amount, scale);

		/// <inheritdoc />
		public string FormatCurrency(ICurrency currency, double amount, int scale) =>

			_currencyFormatter.FormatCurrency(Locale, currency, amount, scale);

		/// <inheritdoc />
		public string FormatCurrency(float amount) =>

			_currencyFormatter.FormatCurrency(Locale, GetDefaultCurrency(), amount);

		/// <inheritdoc />
		public string FormatCurrency(ICurrency currency, float amount) =>

			_currencyFormatter.FormatCurrency(Locale, currency, amount);

		/// <inheritdoc />
		public string FormatCurrency(float amount, int scale) =>

			_currencyFormatter.FormatCurrency(Locale, GetDefaultCurrency(), amount, scale);

		/// <inheritdoc />
		public string FormatCurrency(ICurrency currency, float amount, int scale) =>

			_currencyFormatter.FormatCurrency(Locale, currency, amount, scale);

		/// <inheritdoc />
		public string FormatCurrency(int amount) =>

			_currencyFormatter.FormatCurrency(Locale, GetDefaultCurrency(), amount);

		/// <inheritdoc />
		public string FormatCurrency(ICurrency currency, int amount) =>

			_currencyFormatter.FormatCurrency(Locale, currency, amount);

		/// <inheritdoc />
		public string FormatCurrency(int amount, int scale) =>

			_currencyFormatter.FormatCurrency(Locale, GetDefaultCurrency(), amount, scale);

		/// <inheritdoc />
		public string FormatCurrency(ICurrency currency, int amount, int scale) =>

			_currencyFormatter.FormatCurrency(Locale, currency, amount, scale);

		/// <inheritdoc />
		public string FormatCurrency(long amount) =>

			_currencyFormatter.FormatCurrency(Locale, GetDefaultCurrency(), amount);

		/// <inheritdoc />
		public string FormatCurrency(ICurrency currency, long amount) =>

			_currencyFormatter.FormatCurrency(Locale, currency, amount);

		/// <inheritdoc />
		public string FormatCurrency(long amount, int scale) =>

			_currencyFormatter.FormatCurrency(Locale, GetDefaultCurrency(), amount, scale);

		/// <inheritdoc />
		public string FormatCurrency(ICurrency currency, long amount, int scale) =>

			_currencyFormatter.FormatCurrency(Locale, currency, amount, scale);

		#endregion

		#region Date and time formatting

		public string FormatDate(DateTime moment) =>

			_dateTimeFormatter.FormatDate(Locale, moment);

		public string FormatDateTime(DateTime moment) =>

			_dateTimeFormatter.FormatDateTime(Locale, moment);

		public string FormatShortDate(DateTime moment) =>

			_dateTimeFormatter.FormatShortDate(Locale, moment);

		public string FormatShortDateTime(DateTime moment) =>

			_dateTimeFormatter.FormatShortDateTime(Locale, moment);

		public string FormatShortTime(DateTime moment) =>

			_dateTimeFormatter.FormatShortTime(Locale, moment);

		public string FormatShortTime(TimeSpan moment) =>

			_dateTimeFormatter.FormatShortTime(Locale, moment);

		public string FormatTime(DateTime moment) =>

			_dateTimeFormatter.FormatTime(Locale, moment);

		public string FormatTime(TimeSpan moment) =>

			_dateTimeFormatter.FormatTime(Locale, moment);

		#endregion

		#region Message formatting

		/// <inheritdoc />
		public string FormatMessage(string message, params object[] arguments) =>

			_messageFormatter.FormatMessage
			(
				Locale,
				_messageRepository.GetMessage(Locale, Domain, message),
				arguments
			);

		#endregion

		#region Number formatting

		/// <inheritdoc />
		public string FormatNumber(decimal amount) =>

			_numberFormatter.FormatNumber(Locale, amount);

		/// <inheritdoc />
		public string FormatNumber(decimal amount, int scale) =>

			_numberFormatter.FormatNumber(Locale, amount, scale);

		/// <inheritdoc />
		public string FormatNumber(double amount) =>

			_numberFormatter.FormatNumber(Locale, amount);

		/// <inheritdoc />
		public string FormatNumber(double amount, int scale) =>

			_numberFormatter.FormatNumber(Locale, amount, scale);

		/// <inheritdoc />
		public string FormatNumber(float amount) =>

			_numberFormatter.FormatNumber(Locale, amount);

		/// <inheritdoc />
		public string FormatNumber(float amount, int scale) =>

			_numberFormatter.FormatNumber(Locale, amount, scale);

		/// <inheritdoc />
		public string FormatNumber(int amount) =>

			_numberFormatter.FormatNumber(Locale, amount);

		/// <inheritdoc />
		public string FormatNumber(int amount, int scale) =>

			_numberFormatter.FormatNumber(Locale, amount, scale);

		/// <inheritdoc />
		public string FormatNumber(long amount) =>

			_numberFormatter.FormatNumber(Locale, amount);

		/// <inheritdoc />
		public string FormatNumber(long amount, int scale) =>

			_numberFormatter.FormatNumber(Locale, amount, scale);

		#endregion

		/// <inheritdoc />
		public ICurrency GetDefaultCurrency() =>

			_currencyRepository.GetDefaultCurrency(Locale);

		/// <inheritdoc />
		public string GetMessage(string message) =>

			_messageRepository.GetMessage(Locale, Domain, message);

		/// <inheritdoc />
		public IReadOnlyDictionary<string, string> GetMessages() =>

			_messageRepository.GetMessages(Locale, Domain);
	}
}
