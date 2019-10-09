using System;
using System.Collections.Generic;

public class CharacterCounter
{
  public Dictionary<char, int> Count(string str)
  {
    return new Dictionary<char, int>();
  }
}


/*

Assignment:

The main idea is to count all the occuring characters(UTF-8) in string. If you have string like this aba then the result should be { 'a': 2, 'b': 1 }

What if the string is empty ? Then the result should be empty object literal { }

For C#: Use a Dictionary<char, int> for this kata!

 */