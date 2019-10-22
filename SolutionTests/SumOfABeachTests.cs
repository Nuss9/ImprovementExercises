using Solution;
using Xunit;

namespace SolutionTests
{
	public class SumOfABeachTests
	{
		public SumOfABeach Subject { get; set; }
		public SumOfABeachTests()
		{
			Subject = new SumOfABeach();
		}

		[Fact]
		public void WhenGivenNoInput_ItShouldReturnZero()
		{
			var expected = 0;

			Assert.Equal(expected, Subject.SumOfABeachCounter(""));
			Assert.Equal(expected, Subject.SumOfABeachCounter(null));
		}

		[InlineData("sun")]
		[InlineData("sand")]
		[InlineData("fish")]
		[InlineData("water")]
		[Theory]
		public void WhenGivenASummerWord_ItShouldReturnOne(string input)
		{
			 var expected = 1;

			 Assert.Equal(expected, Subject.SumOfABeachCounter(input));
		}

		[Fact]
		public void WhenInputContainsASummerWordWithNonsense_ItShouldReturnOne()
		{
			var input = "vbnrfjkeaSun";
			var expected = 1;

			Assert.Equal(expected, Subject.SumOfABeachCounter(input));
		}

		/*
		[Fact]
		public void FinalTest1()
		{
     		Assert.Equal(1, subject.SumOfABeachCounter("123FISH321"));
		}

		[Fact]
		public void FinalTest2()
		{
     		 Assert.Equal(1, subject.SumOfABeachCounter("SanD"));
		}

		[Fact]
		public void FinalTest3()
		{
      		Assert.Equal(4, subject.SumOfABeachCounter("sunsunsunsun"));
		}

		[Fact]
		public void FinalTest4()
		{
      		Assert.Equal(1, subject.SumOfABeachCounter("sunshine"));
		}
		*/
	}
}
