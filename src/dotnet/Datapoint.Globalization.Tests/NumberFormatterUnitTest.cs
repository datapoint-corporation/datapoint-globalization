using System.Globalization;
using Xunit;

namespace Datapoint.Globalization.Tests
{
	public sealed class NumberFormatterUnitTest
	{
		private readonly ILocale _locale;

		private readonly INumberFormatter _numberFormatter;

		public NumberFormatterUnitTest()
		{
			_numberFormatter = new NumberFormatter();

			_locale = new Locale(CultureInfo.CurrentCulture, RegionInfo.CurrentRegion);
		}

		[Fact]
		public void FormatNumberWithDecimal()
		{
			Assert.Equal
			(
				1234.567M.ToString("N2"),
				_numberFormatter.FormatNumber(_locale, 1234.567M, 2)
			);
		}

		[Fact]
		public void FormatNumberWithDouble()
		{
			Assert.Equal
			(
				1234.567D.ToString("N2"),
				_numberFormatter.FormatNumber(_locale, 1234.567D, 2)
			);
		}

		[Fact]
		public void FormatNumberWithFloat()
		{
			Assert.Equal
			(
				1234.567F.ToString("N2"),
				_numberFormatter.FormatNumber(_locale, 1234.567F, 2)
			);
		}

		[Fact]
		public void FormatNumberWithInteger()
		{
			Assert.Equal
			(
				1234.ToString("N2"),
				_numberFormatter.FormatNumber(_locale, 1234, 2)
			);
		}

		[Fact]
		public void FormatNumberWithLong()
		{
			Assert.Equal
			(
				1234L.ToString("N2"),
				_numberFormatter.FormatNumber(_locale, 1234L, 2)
			);
		}
	}
}
