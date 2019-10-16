using Solution;
using Xunit;

namespace SolutionTests
{
	public class SumOfABeachTests
	{
		public SumOfABeach subject { get; set; }
		public SumOfABeachTests()
		{
			this.subject = new SumOfABeach();
		}

		[Fact]
		public void WhenGivenNoInput_ItShouldReturnZero()
		{
			Assert.Equal(0, subject.SumOfABeachCounter(""));
			Assert.Equal(0, subject.SumOfABeachCounter(null));
		}

		[InlineData("sun")]
		[InlineData("sand")]
		[InlineData("fish")]
		[InlineData("water")]
		[Theory]
		public void WhenGivenASummerWord_ItShouldReturnOne(string input)
		{
			 int expected = 1;

			 Assert.Equal(expected, subject.SumOfABeachCounter(input));
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
