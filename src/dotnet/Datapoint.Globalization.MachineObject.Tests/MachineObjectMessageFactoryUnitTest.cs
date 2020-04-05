using System.Globalization;
using System.Linq;
using Xunit;

namespace Datapoint.Globalization.MachineObject.Tests
{
	public class MachineObjectMessageFactoryUnitTest
	{
		private readonly MachineObjectMessageFactory _factory;

		private readonly ILocale _locale;

		public MachineObjectMessageFactoryUnitTest()
		{
			_factory = new MachineObjectMessageFactory();

			_locale = new Locale
			(
				new System.Globalization.CultureInfo("pt-PT"),
				new RegionInfo("PT")
			);
		}

		[Fact]
		public void HasHelloWorldTranslation()
		{
			Assert.Single
			(
				_factory.CreateMessages(_locale, "default")
					.Where(m => m.Key.Equals("Hello World"))
					.Where(m => m.Value.Equals("Olá Mundo"))
			);
		}

		[Fact]
		public void HasGoodbyeWorldTranslation()
		{
			Assert.Single
			(
				_factory.CreateMessages(_locale, "default")
					.Where(m => m.Key.Equals("Goodbye World"))
					.Where(m => m.Value.Equals("Adeus Mundo"))
			);
		}

		[Fact]
		public void HasNeutralTranslation()
		{
			Assert.Single
			(
				_factory.CreateMessages(_locale, "default")
					.Where(m => m.Key.Equals("Invariant Translation (locale)"))
					.Where(m => m.Value.Equals("Tradução Invariante (pt)"))
			);
		}

		[Fact]
		public void HasSpecificTranslation()
		{
			Assert.Single
			(
				_factory.CreateMessages(_locale, "default")
					.Where(m => m.Key.Equals("Specific Translation (locale)"))
					.Where(m => m.Value.Equals("Tradução Específica (pt-PT)"))
			);
		}
	}
}
