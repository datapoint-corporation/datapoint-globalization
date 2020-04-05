using Datapoint.Globalization.Environment;
using System.Globalization;
using Xunit;

namespace Datapoint.Globalization.Tests
{
	public sealed class CurrencyFormatterUnitTest
	{
		private readonly ICurrency _alternativeCurrency;

		private readonly NumberFormatInfo _alternativeCurrencyNumberFormatInfo;

		private readonly ICurrencyRepository _currencyRepository;

		private readonly ICurrency _currency;

		private readonly ICurrencyFormatter _currencyFormatter;

		private readonly ILocale _locale;

		private readonly ILocaleRepository _localeRepository;

		public CurrencyFormatterUnitTest()
		{
			_currencyRepository = new CurrencyRepository(new EnvironmentCurrencyFactory());
			_localeRepository = new LocaleRepository(new EnvironmentLocaleFactory());

			_locale = _localeRepository.GetLocale("pt-PT");
			_currency = _currencyRepository.GetDefaultCurrency(_locale);
			_alternativeCurrency = _currencyRepository.GetCurrency("USD");

			_currencyFormatter = new CurrencyFormatter();

			_alternativeCurrencyNumberFormatInfo = (NumberFormatInfo)_locale.Culture.NumberFormat.Clone();
			_alternativeCurrencyNumberFormatInfo.CurrencyDecimalDigits = _alternativeCurrency.Scale;
			_alternativeCurrencyNumberFormatInfo.CurrencySymbol = _alternativeCurrency.Symbol;
		}

		[Fact]
		public void FormatAlternativeCurrencyWithDecimal()
		{
			Assert.Equal
			(
				1234.567M.ToString("C", _alternativeCurrencyNumberFormatInfo),
				_currencyFormatter.FormatCurrency(_locale, _alternativeCurrency, 1234.567M)
			);
		}

		[Fact]
		public void FormatAlternativeCurrencyWithDouble()
		{
			Assert.Equal
			(
				1234.567D.ToString("C", _alternativeCurrencyNumberFormatInfo),
				_currencyFormatter.FormatCurrency(_locale, _alternativeCurrency, 1234.567D)
			);
		}

		[Fact]
		public void FormatAlternativeCurrencyWithFloat()
		{
			Assert.Equal
			(
				1234.567F.ToString("C", _alternativeCurrencyNumberFormatInfo),
				_currencyFormatter.FormatCurrency(_locale, _alternativeCurrency, 1234.567F)
			);
		}

		[Fact]
		public void FormatAlternativeCurrencyWithInteger()
		{
			Assert.Equal
			(
				1234.ToString("C", _alternativeCurrencyNumberFormatInfo),
				_currencyFormatter.FormatCurrency(_locale, _alternativeCurrency, 1234)
			);
		}

		[Fact]
		public void FormatAlternativeCurrencyWithLong()
		{
			Assert.Equal
			(
				1234L.ToString("C", _alternativeCurrencyNumberFormatInfo),
				_currencyFormatter.FormatCurrency(_locale, _alternativeCurrency, 1234L)
			);
		}

		[Fact]
		public void FormatCurrencyWithDecimal()
		{
			Assert.Equal
			(
				1234.567M.ToString("C"),
				_currencyFormatter.FormatCurrency(_locale, _currency, 1234.567M)
			);
		}

		[Fact]
		public void FormatCurrencyWithDouble()
		{
			Assert.Equal
			(
				1234.567D.ToString("C"),
				_currencyFormatter.FormatCurrency(_locale, _currency, 1234.567D)
			);
		}

		[Fact]
		public void FormatCurrencyWithFloat()
		{
			Assert.Equal
			(
				1234.567F.ToString("C"),
				_currencyFormatter.FormatCurrency(_locale, _currency, 1234.567F)
			);
		}

		[Fact]
		public void FormatCurrencyWithInteger()
		{
			Assert.Equal
			(
				1234.ToString("C"),
				_currencyFormatter.FormatCurrency(_locale, _currency, 1234, 2)
			);
		}

		[Fact]
		public void FormatCurrencyWithLong()
		{
			Assert.Equal
			(
				1234L.ToString("C"),
				_currencyFormatter.FormatCurrency(_locale, _currency, 1234L)
			);
		}
	}
}
