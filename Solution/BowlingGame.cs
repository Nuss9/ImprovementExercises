using System;

namespace Solution
{
	public class Game
	{
		private int currentRoll = 0;
		private int[] rolls = new int[21];

		public void Roll(int pins)
		{
			rolls[currentRoll++] = pins;
		}

		public int Result()
		{
			int score = 0;

			for(int i =0; i < rolls.Length; i++) {
				score += rolls[i];
			}

			return score;
		}
	}
}
