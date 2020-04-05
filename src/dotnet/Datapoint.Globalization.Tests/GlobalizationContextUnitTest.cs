using Datapoint.Globalization.Environment;
using Datapoint.Globalization.MachineObject;
using System;
using System.Globalization;
using Xunit;

namespace Datapoint.Globalization.Tests
{
	public sealed class GlobalizationContextUnitTest
	{
		private readonly ICurrency _alternativeCurrency;

		private readonly NumberFormatInfo _alternativeCurrencyNumberFormatInfo;

		private readonly ICurrencyRepository _currencyRepository;

		private readonly IGlobalizationContext _globalizationContext;

		private readonly ILocale _locale;

		private readonly ILocaleRepository _localeRepository;

		public GlobalizationContextUnitTest()
		{
			var guow = new GlobalizationUnitOfWork
			(
				new CurrencyRepository(new EnvironmentCurrencyFactory()),
				new LocaleRepository(new EnvironmentLocaleFactory()),
				new MessageRepository(new MachineObjectMessageFactory())
			);

			_currencyRepository = guow.Currencies;

			_localeRepository = guow.Locales;

			_locale = guow.Locales.GetLocale("pt-PT");

			_globalizationContext = guow.CreateContext("pt-PT", "default");

			_alternativeCurrency = guow.Currencies.GetCurrency("USD");

			_alternativeCurrencyNumberFormatInfo = (NumberFormatInfo)_locale.Culture.NumberFormat.Clone();
			_alternativeCurrencyNumberFormatInfo.CurrencyDecimalDigits = _alternativeCurrency.Scale;
			_alternativeCurrencyNumberFormatInfo.CurrencySymbol = _alternativeCurrency.Symbol;
		}

		#region Currency formatting

		[Fact]
		public void FormatCurrencyWithDecimal() =>

			Assert.Equal
			(
				1234.56m.ToString("C", _locale.Culture.NumberFormat),
				_globalizationContext.FormatCurrency(1234.56m)
			);

		[Fact]
		public void FormatCurrencyWithDecimalAndScale() =>

			Assert.Equal
			(
				1234.56m.ToString("C4", _locale.Culture.NumberFormat),
				_globalizationContext.FormatCurrency(1234.56m, 4)
			);

		[Fact]
		public void FormatAlternativeCurrencyWithDecimal() =>

			Assert.Equal
			(
				1234.56m.ToString("C", _alternativeCurrencyNumberFormatInfo),
				_globalizationContext.FormatCurrency(_alternativeCurrency, 1234.56m)
			);

		[Fact]
		public void FormatAlternativeCurrencyWithDecimalAndScale() =>

			Assert.Equal
			(
				1234.56m.ToString("C4", _alternativeCurrencyNumberFormatInfo),
				_globalizationContext.FormatCurrency(_alternativeCurrency, 1234.56m, 4)
			);

		[Fact]
		public void FormatCurrencyWithDouble() =>

			Assert.Equal
			(
				1234.56d.ToString("C", _locale.Culture.NumberFormat),
				_globalizationContext.FormatCurrency(1234.56d)
			);

		[Fact]
		public void FormatCurrencyWithDoubleAndScale() =>

			Assert.Equal
			(
				1234.56d.ToString("C4", _locale.Culture.NumberFormat),
				_globalizationContext.FormatCurrency(1234.56d, 4)
			);

		[Fact]
		public void FormatAlternativeCurrencyWithDouble() =>

			Assert.Equal
			(
				1234.56d.ToString("C", _alternativeCurrencyNumberFormatInfo),
				_globalizationContext.FormatCurrency(_alternativeCurrency, 1234.56d)
			);

		[Fact]
		public void FormatAlternativeCurrencyWithDoubleAndScale() =>

			Assert.Equal
			(
				1234.56d.ToString("C4", _alternativeCurrencyNumberFormatInfo),
				_globalizationContext.FormatCurrency(_alternativeCurrency, 1234.56d, 4)
			);

		[Fact]
		public void FormatCurrencyWithFloat() =>

			Assert.Equal
			(
				1234.56f.ToString("C", _locale.Culture.NumberFormat),
				_globalizationContext.FormatCurrency(1234.56f)
			);

		[Fact]
		public void FormatCurrencyWithFloatAndScale() =>

			Assert.Equal
			(
				1234.56f.ToString("C4", _locale.Culture.NumberFormat),
				_globalizationContext.FormatCurrency(1234.56f, 4)
			);

		[Fact]
		public void FormatAlternativeCurrencyWithFloat() =>

			Assert.Equal
			(
				1234.56f.ToString("C", _alternativeCurrencyNumberFormatInfo),
				_globalizationContext.FormatCurrency(_alternativeCurrency, 1234.56f)
			);

		[Fact]
		public void FormatAlternativeCurrencyWithFloatAndScale() =>

			Assert.Equal
			(
				1234.56f.ToString("C4", _alternativeCurrencyNumberFormatInfo),
				_globalizationContext.FormatCurrency(_alternativeCurrency, 1234.56f, 4)
			);

		[Fact]
		public void FormatCurrencyWithInteger() =>

			Assert.Equal
			(
				1234.ToString("C", _locale.Culture.NumberFormat),
				_globalizationContext.FormatCurrency(1234)
			);

		[Fact]
		public void FormatCurrencyWithIntegerAndScale() =>

			Assert.Equal
			(
				1234.ToString("C4", _locale.Culture.NumberFormat),
				_globalizationContext.FormatCurrency(1234, 4)
			);

		[Fact]
		public void FormatAlternativeCurrencyWithInteger() =>

			Assert.Equal
			(
				1234.ToString("C", _alternativeCurrencyNumberFormatInfo),
				_globalizationContext.FormatCurrency(_alternativeCurrency, 1234)
			);

		[Fact]
		public void FormatAlternativeCurrencyWithIntegerAndScale() =>

			Assert.Equal
			(
				1234.ToString("C4", _alternativeCurrencyNumberFormatInfo),
				_globalizationContext.FormatCurrency(_alternativeCurrency, 1234, 4)
			);

		[Fact]
		public void FormatCurrencyWithLong() =>

			Assert.Equal
			(
				1234L.ToString("C", _locale.Culture.NumberFormat),
				_globalizationContext.FormatCurrency(1234L)
			);

		[Fact]
		public void FormatCurrencyWithLongAndScale() =>

			Assert.Equal
			(
				1234L.ToString("C4", _locale.Culture.NumberFormat),
				_globalizationContext.FormatCurrency(1234L, 4)
			);

		[Fact]
		public void FormatAlternativeCurrencyWithLong() =>

			Assert.Equal
			(
				1234L.ToString("C", _alternativeCurrencyNumberFormatInfo),
				_globalizationContext.FormatCurrency(_alternativeCurrency, 1234L)
			);

		[Fact]
		public void FormatAlternativeCurrencyWithLongAndScale() =>

			Assert.Equal
			(
				1234L.ToString("C4", _alternativeCurrencyNumberFormatInfo),
				_globalizationContext.FormatCurrency(_alternativeCurrency, 1234L, 4)
			);

		#endregion

		#region Date and time formatting

		[Fact]
		public void FormatDate()
		{
			var moment = DateTime.Now;

			Assert.Equal
			(
				moment.ToString("D"),
				_globalizationContext.FormatDate(moment)
			);
		}

		[Fact]
		public void FormatDateTime()
		{
			var moment = DateTime.Now;

			Assert.Equal
			(
				moment.ToString("F"),
				_globalizationContext.FormatDateTime(moment)
			);
		}

		[Fact]
		public void FormatShortDate()
		{
			var moment = DateTime.Now;

			Assert.Equal
			(
				moment.ToString("d"),
				_globalizationContext.FormatShortDate(moment)
			);
		}

		[Fact]
		public void FormatShortDateTime()
		{
			var moment = DateTime.Now;

			Assert.Equal
			(
				moment.ToString("f"),
				_globalizationContext.FormatShortDateTime(moment)
			);
		}

		[Fact]
		public void FormatTime()
		{
			var moment = DateTime.Now;

			Assert.Equal
			(
				moment.ToString("T"),
				_globalizationContext.FormatTime(moment)
			);
		}

		[Fact]
		public void FormatShortTimeWithSpan()
		{
			var moment = DateTime.Now.TimeOfDay;

			Assert.Equal
			(
				moment.ToString("t"),
				_globalizationContext.FormatShortTime(moment)
			);
		}

		[Fact]
		public void FormatTimeWithSpan()
		{
			var moment = DateTime.Now.TimeOfDay;

			Assert.Equal
			(
				moment.ToString("T"),
				_globalizationContext.FormatShortTime(moment)
			);
		}

		#endregion

		#region Message formatting

		[Fact]
		public void FormatMessage() =>

			Assert.Equal
			(
				"Olá Mundo",
				_globalizationContext.FormatMessage("Hello World")
			);

		[Fact]
		public void FormatMessageWithArguments() =>

			Assert.Equal
			(
				"Hello John, I am a non existant message with 2 arguments.",
				_globalizationContext.FormatMessage("Hello {0}, I am a non existant message with {1} arguments.", "John", 2)
			);

		#endregion

		#region Number formatting

		[Fact]
		public void FormatNumberWithDecimal() =>

			Assert.Equal
			(
				1234.56M.ToString("N", _locale.Culture),
				_globalizationContext.FormatNumber(1234.56M)
			);

		[Fact]
		public void FormatNumberWithDecimalAndScale() =>

			Assert.Equal
			(
				1234.56M.ToString("N4", _locale.Culture),
				_globalizationContext.FormatNumber(1234.56M, 4)
			);

		[Fact]
		public void FormatNumberWithDouble() =>

			Assert.Equal
			(
				1234.56D.ToString("N", _locale.Culture),
				_globalizationContext.FormatNumber(1234.56D)
			);

		[Fact]
		public void FormatNumberWithDoubleAndScale() =>

			Assert.Equal
			(
				1234.56D.ToString("N4", _locale.Culture),
				_globalizationContext.FormatNumber(1234.56D, 4)
			);

		[Fact]
		public void FormatNumberWithFloat() =>

			Assert.Equal
			(
				1234.56F.ToString("N", _locale.Culture),
				_globalizationContext.FormatNumber(1234.56F)
			);

		[Fact]
		public void FormatNumberWithFloatAndScale() =>

			Assert.Equal
			(
				1234.56F.ToString("N4", _locale.Culture),
				_globalizationContext.FormatNumber(1234.56F, 4)
			);

		[Fact]
		public void FormatNumberWithInteger() =>

			Assert.Equal
			(
				1234.ToString("N", _locale.Culture),
				_globalizationContext.FormatNumber(1234)
			);

		[Fact]
		public void FormatNumberWithIntegerAndScale() =>

			Assert.Equal
			(
				1234.ToString("N4", _locale.Culture),
				_globalizationContext.FormatNumber(1234, 4)
			);

		[Fact]
		public void FormatNumberWithLong() =>

			Assert.Equal
			(
				1234.ToString("N", _locale.Culture),
				_globalizationContext.FormatNumber(1234)
			);

		[Fact]
		public void FormatNumberWithLongAndScale() =>

			Assert.Equal
			(
				1234L.ToString("N4", _locale.Culture),
				_globalizationContext.FormatNumber(1234L, 4)
			);

		#endregion
	}
}
