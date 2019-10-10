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
	}
}
