using System;

public static class RotationalCipher
{
  public static string Rotate(string text, int shiftKey)
  {
    string rotatedText = "";
    foreach (char letter in text)
    {
      char modifiedChar = '\0';
      if (letter == ' ')
      {
        modifiedChar = letter;
      }
      else if (letter >= 'a' && letter <= 'z')
      {
        int shiftedValue = (int)letter + shiftKey;
        if (shiftedValue > 122) shiftedValue = 97 + (shiftedValue % 123);
        modifiedChar = (char)shiftedValue;
      }
      else if (letter >= 'A' && letter <= 'Z')
      {
        int shiftedValue = (int)letter + shiftKey;
        if (shiftedValue > 90) shiftedValue = 65 + (shiftedValue % 91);
        modifiedChar = (char)shiftedValue;
      }
      else
      {
        modifiedChar = letter;
      }

      Console.WriteLine(modifiedChar);
      rotatedText += modifiedChar;
    }

    return rotatedText;
  }
}