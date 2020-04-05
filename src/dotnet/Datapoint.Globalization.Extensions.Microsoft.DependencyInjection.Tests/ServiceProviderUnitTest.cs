using Datapoint.Globalization.Environment;
using Datapoint.Globalization.MachineObject;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Datapoint.Globalization.Extensions.Microsoft.DependencyInjection.Tests
{
	public class ServiceProviderUnitTest
	{
		private readonly IGlobalizationUnitOfWork _globalizationUnitOfWork;

		public ServiceProviderUnitTest()
		{
			_globalizationUnitOfWork = new ServiceCollection()
				.AddGlobalization<EnvironmentCurrencyFactory, EnvironmentLocaleFactory, MachineObjectMessageFactory>()
				.BuildServiceProvider()
				.GetService<IGlobalizationUnitOfWork>();
		}

		[Fact]
		public void HasGlobalizationUnitOfWork()
		{
			Assert.NotNull(_globalizationUnitOfWork);
		}

		[Fact]
		public void HasCurrencyRepository()
		{
			Assert.NotNull(_globalizationUnitOfWork.Currencies);
		}

		[Fact]
		public void HasLocaleRepository()
		{
			Assert.NotNull(_globalizationUnitOfWork.Locales);
		}

		[Fact]
		public void HasMessageRepository()
		{
			Assert.NotNull(_globalizationUnitOfWork.Messages);
		}

		[Fact]
		public void HasCurrency()
		{
			Assert.NotNull(_globalizationUnitOfWork.Currencies.GetCurrency("EUR"));
		}

		[Fact]
		public void HasLocale()
		{
			Assert.NotNull(_globalizationUnitOfWork.Locales.GetLocale("pt-PT"));
		}

		[Fact]
		public void HasMessage()
		{
			Assert.Equal
			(
				"Olá Mundo",
				_globalizationUnitOfWork
					.CreateContext("pt-PT", "default")
					.GetMessage("Hello World")
			);
		}
	}
}
