using Datapoint.Globalization.Environment;
using Xunit;

namespace Datapoint.Globalization.Tests
{
	public sealed class CurrencyRepositoryUnitTest
	{
		private readonly ICurrencyRepository _currencies;

		private readonly ILocaleRepository _locales;

		public CurrencyRepositoryUnitTest()
		{
			_currencies = new CurrencyRepository
			(
				new EnvironmentCurrencyFactory()
			);

			_locales = new LocaleRepository
			(
				new EnvironmentLocaleFactory()
			);
		}

		[Fact]
		public void HasEuro()
		{
			var currency = _currencies.GetCurrency("EUR");

			Assert.NotNull(currency);
			Assert.True(currency.Code.Equals("EUR"));
			Assert.True(currency.Scale.Equals(2));
		}

		[Fact]
		public void HasEuroAsDefault()
		{
			var locale = _locales.GetLocale("pt-PT");

			Assert.NotNull(locale);
			Assert.True(locale.Culture.Name.Equals("pt-PT"));
			Assert.True(locale.Culture.TwoLetterISOLanguageName.Equals("pt"));
			Assert.True(locale.Region.TwoLetterISORegionName.Equals("PT"));

			var currency = _currencies.GetDefaultCurrency(locale);

			Assert.NotNull(currency);
			Assert.True(currency.Code.Equals("EUR"));
			Assert.True(currency.Scale.Equals(2));
		}

		[Fact]
		public void HasGreatBritainPound()
		{
			var currency = _currencies.GetCurrency("GBP");

			Assert.NotNull(currency);
			Assert.True(currency.Code.Equals("GBP"));
			Assert.True(currency.Scale.Equals(2));
		}

		[Fact]
		public void HasGreatBritainPoundAsDefault()
		{
			var locale = _locales.GetLocale("en-GB");

			Assert.NotNull(locale);
			Assert.True(locale.Culture.Name.Equals("en-GB"));
			Assert.True(locale.Culture.TwoLetterISOLanguageName.Equals("en"));
			Assert.True(locale.Region.TwoLetterISORegionName.Equals("GB"));

			var currency = _currencies.GetDefaultCurrency(locale);

			Assert.NotNull(currency);
			Assert.True(currency.Code.Equals("GBP"));
			Assert.True(currency.Scale.Equals(2));
		}

		[Fact]
		public void HasUnitedStatesDollar()
		{
			var currency = _currencies.GetCurrency("USD");

			Assert.NotNull(currency);
			Assert.True(currency.Code.Equals("USD"));
			Assert.True(currency.Scale.Equals(2));
		}

		[Fact]
		public void HasUnitedStatesDollarAsDefault()
		{
			var locale = _locales.GetLocale("en-US");

			Assert.NotNull(locale);
			Assert.True(locale.Culture.Name.Equals("en-US"));
			Assert.True(locale.Culture.TwoLetterISOLanguageName.Equals("en"));
			Assert.True(locale.Region.TwoLetterISORegionName.Equals("US"));

			var currency = _currencies.GetDefaultCurrency(locale);

			Assert.NotNull(currency);
			Assert.True(currency.Code.Equals("USD"));
			Assert.True(currency.Scale.Equals(2));
		}
	}
}
