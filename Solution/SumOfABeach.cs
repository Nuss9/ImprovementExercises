using System.Collections.Generic;

namespace Solution
{
	public class SumOfABeach
	{
		private readonly List<string> summerWords = new List<string> {
				"sun",
				"sand",
				"fish",
				"water"
			};

		public int SumOfABeachCounter(string input)
		{
			if(string.IsNullOrWhiteSpace(input)) {
				return 0;
			}

			var loweredInput = input.ToLower();
			var counter = 0;

			if(summerWords.Contains(loweredInput)) {
				counter++;
			}

			return counter;
		}
	}
}