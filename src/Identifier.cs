using System;

public static class Identifier
{
  public static string Clean(string identifier)
  {
    string modifiedString = identifier.Replace(' ', '_').Replace("\0", "CTRL");
    if (modifiedString.IndexOf('-') != -1)
    {
      string[] modifiedStringList = modifiedString.Split('-');
      modifiedString = $"{modifiedStringList[0]}{char.ToUpper(modifiedStringList[1][0])}{modifiedStringList[1].Substring(1)}";
    }

    string filteredModifiedString = "";
    for (int idx = 0; idx < modifiedString.Length; idx++)
    {
      char ch = modifiedString[idx];
      if (!(ch >= 'α' && ch <= 'ω') && (Char.IsLetter(ch) || ch == '_')) filteredModifiedString += ch;
    }

    return filteredModifiedString;
  }
}
