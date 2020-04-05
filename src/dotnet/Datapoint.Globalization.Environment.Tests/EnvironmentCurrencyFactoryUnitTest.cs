using System.Linq;
using Xunit;

namespace Datapoint.Globalization.Environment.Tests
{
	public class EnvironmentCurrencyFactoryUnitTest
	{
		private readonly EnvironmentCurrencyFactory _factory;

		public EnvironmentCurrencyFactoryUnitTest()
		{
			_factory = new EnvironmentCurrencyFactory();
		}

		[Fact]
		public void CreateEuro()
		{
			var currency = _factory.CreateCurrencies()
				.Where(c => c.Code == "EUR")
				.First();

			Assert.Equal("EUR", currency.Code);
			Assert.Equal("€", currency.Symbol);
			Assert.Equal(2, currency.Scale);
		}

		[Fact]
		public void CreateGreatBritainPound()
		{
			var currency = _factory.CreateCurrencies()
				.Where(c => c.Code == "GBP")
				.First();

			Assert.Equal("GBP", currency.Code);
			Assert.Equal("£", currency.Symbol);
			Assert.Equal(2, currency.Scale);
		}

		[Fact]
		public void CreateUnitedStatesDollar()
		{
			var currency = _factory.CreateCurrencies()
				.Where(c => c.Code == "USD")
				.First();

			Assert.Equal("USD", currency.Code);
			Assert.Equal("$", currency.Symbol);
			Assert.Equal(2, currency.Scale);
		}
	}
}
