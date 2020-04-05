using System.Globalization;
using System.Linq;
using Xunit;

namespace Datapoint.Globalization.Environment.Tests
{
	public sealed class EnvironmentLocaleFactoryUnitTest
	{
		private readonly EnvironmentLocaleFactory _factory;

		public EnvironmentLocaleFactoryUnitTest()
		{
			_factory = new EnvironmentLocaleFactory();
		}

		[Fact]
		public void CreatePortuguese() =>

			Assert.Single
			(
				_factory.CreateLocales()
					.Where(lc => lc.Culture.Name.Equals("pt"))
					.Where(lc => lc.Region.Equals(RegionInfo.CurrentRegion))
			);

		[Fact]
		public void CreatePortuguesePortugal() =>

			Assert.Single
			(
				_factory.CreateLocales()
					.Where(lc => lc.Culture.Name.Equals("pt-PT"))
					.Where(lc => lc.Region.TwoLetterISORegionName.Equals("PT"))
			);

		[Fact]
		public void CreateEnglish() =>

			Assert.Single
			(
				_factory.CreateLocales()
					.Where(lc => lc.Culture.Name.Equals("en"))
					.Where(lc => lc.Region.Equals(RegionInfo.CurrentRegion))
			);

		[Fact]
		public void CreateEnglishGreatBritain() =>

			Assert.Single
			(
				_factory.CreateLocales()
					.Where(lc => lc.Culture.Name.Equals("en-GB"))
					.Where(lc => lc.Region.TwoLetterISORegionName.Equals("GB"))
			);

		[Fact]
		public void CreateEnglishUnitedStates() =>

			Assert.Single
			(
				_factory.CreateLocales()
					.Where(lc => lc.Culture.Name.Equals("en-US"))
					.Where(lc => lc.Region.TwoLetterISORegionName.Equals("US"))
			);
	}
}
