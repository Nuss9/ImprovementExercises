using System;
using Solution;
using Xunit;

namespace SolutionTests
{
	public class BowlingGameTests
	{
		public Game game = new Game();

		[Fact]
		public void WhenThrowingAllGutters_ItShouldScore0()
		{
			RollMany(20, 0);

			Assert.Equal(0, game.Result());
		}

		[Fact]
		public void WhenThrowingAllOnes_ItShouldScore20()
		{
			RollMany(20, 1);

			Assert.Equal(20, game.Result());
		}

		[Fact]
		public void WhenThrowing553_ItShouldScore16()
		{
			RollMany(2, 5);
			RollMany(1, 3);
			RollMany(17, 0);

			Assert.Equal(16, game.Result());
		}

		private void RollMany(int rolls, int pins)
		{
			for(int i = 0; i < rolls; i++) {
				game.Roll(pins);
			}
		}
	}
}
