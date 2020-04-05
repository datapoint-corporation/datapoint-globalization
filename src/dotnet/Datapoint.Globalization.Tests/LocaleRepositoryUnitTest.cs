using Datapoint.Globalization.Environment;
using System.Globalization;
using Xunit;

namespace Datapoint.Globalization.Tests
{
	public class LocaleRepositoryUnitTest
	{
		private readonly ILocaleRepository _locales;

		public LocaleRepositoryUnitTest()
		{
			_locales = new LocaleRepository
			(
				new EnvironmentLocaleFactory()
			);
		}

		[Fact]
		public void HasEverySystemLocale()
		{
			foreach (var culture in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
			{
				var region = new RegionInfo(culture.Name);

				var locale = _locales.GetLocale(culture.Name);

				Assert.NotNull(locale);
				Assert.NotNull(locale.Culture);
				Assert.NotNull(locale.Region);

				Assert.False(locale.Culture.IsNeutralCulture);

				Assert.True(locale.Culture.Equals(culture));
				Assert.True(locale.Region.Equals(region));
			}
		}

		[Fact]
		public void HasUnitedStatesEnglishLocale()
		{
			var locale = _locales.GetLocale("en-US");

			Assert.NotNull(locale);
			Assert.NotNull(locale.Culture);
			Assert.NotNull(locale.Region);

			Assert.True(locale.Culture.Name.Equals("en-US"));
			Assert.True(locale.Region.Name.Equals("US"));
		}

		[Fact]
		public void HasEnglishLocale()
		{
			var locale = _locales.GetLocale("en");

			Assert.NotNull(locale);
			Assert.NotNull(locale.Culture);
			Assert.NotNull(locale.Region);

			Assert.True(locale.Culture.Name.Equals("en"));
			Assert.True(locale.Region.Equals(RegionInfo.CurrentRegion));
		}

		[Fact]
		public void ThrownsLocaleNotFoundException()
		{
			Assert.Throws<LocaleNotFoundException>(() => _locales.GetLocale("this-locale-does-not-exist--for-sure"));
		}
	}
}
