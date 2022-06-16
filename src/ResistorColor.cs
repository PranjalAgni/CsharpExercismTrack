using System;
public static class ResistorColor
{
  public static int ColorCode(string color)
  {
    string[] colorsList = Colors();
    for (int idx = 0; idx < colorsList.Length; idx++)
    {
      if (String.Equals(color, colorsList[idx]))
      {
        return idx;
      }
    }
    return -1;
  }
  public static string[] Colors()
  {
    string[] colorsList = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    return colorsList;
  }
}