using Solution;
using Xunit;

namespace SolutionTests
{
	public class DuplicateEncoderTests
	{
		public DuplicateEncoder Subject { get; set; }

		public DuplicateEncoderTests()
		{
			Subject = new DuplicateEncoder();
		}

		[Fact]
		public void Test1()
		{
			Assert.Equal("(((", "din");
		}

		[Fact]
		public void Test2()
		{
			Assert.Equal("()()()", "recede");
		}

		[Fact]
		public void Test3()
		{
			Assert.Equal(")())())", "Success");
		}

		[Fact]
		public void Test4()
		{
			Assert.Equal("))((", "(( @");
		}
	}
}