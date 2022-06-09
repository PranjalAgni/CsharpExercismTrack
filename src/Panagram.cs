using System;
using System.Collections.Generic;
using System.Linq;

public static class Pangram
{
  public static bool IsPangram(string input)
  {

    var frequencyList = new List<int>(Enumerable.Repeat(0, 26));
    foreach (char letter in input)
    {
      char lowerCaseLetter = Char.ToLower(letter);
      if (lowerCaseLetter >= 'a' && lowerCaseLetter <= 'z')
      {
        int index = lowerCaseLetter - 'a';
        frequencyList[index] = 1;
      }
    }

    foreach (int freq in frequencyList)
    {
      if (freq != 1) return false;
    }

    return true;
  }
}
