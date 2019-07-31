using Solution;
using Xunit;

namespace SolutionTests
{
	public class SheepTests
	{
		/* 
		Level 8 

		Given a non-negative integer, 3 for example, return a string with a murmur: 
		"1 sheep...2 sheep...3 sheep...". Input will always be valid, i.e. no negative integers. 
		*/

		[Fact]
		public void LastTest()
		{
			Assert.Equal("1 sheep...", Sheep.CountSheep(1));
			Assert.Equal("1 sheep...2 sheep...", Sheep.CountSheep(2));
			Assert.Equal("1 sheep...2 sheep...3 sheep...", Sheep.CountSheep(3));
		}
	}
}
