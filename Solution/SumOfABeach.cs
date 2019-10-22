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

			foreach (var word in summerWords)
			{
				while (loweredInput.Contains(word))
				{
					loweredInput = loweredInput.Remove(loweredInput.IndexOf(word), word.Length);
					counter++;
				}
			}

			return counter;
		}
	}
}