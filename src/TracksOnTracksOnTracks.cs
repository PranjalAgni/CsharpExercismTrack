using System;
using System.Collections.Generic;

public static class Languages
{
  public static List<string> NewList()
  {
    return new List<string>();
  }

  public static List<string> GetExistingLanguages()
  {
    return new List<string>() { "C#", "Clojure", "Elm" };
  }

  public static List<string> AddLanguage(List<string> languages, string language)
  {
    languages.Add(language);
    return languages;
  }

  public static int CountLanguages(List<string> languages)
  {
    return languages.Count;
  }

  public static bool HasLanguage(List<string> languages, string language)
  {
    return languages.Contains(language);
  }

  public static List<string> ReverseList(List<string> languages)
  {
    languages.Reverse();
    return languages;
  }

  public static bool IsExciting(List<string> languages)
  {
    int indexOfCsharp = languages.IndexOf("C#");
    if (indexOfCsharp == 0) return true;
    if (indexOfCsharp == 1 && languages.Count <= 3) return true;
    return false;
  }

  public static List<string> RemoveLanguage(List<string> languages, string language)
  {
    int indexOfLanguage = languages.IndexOf(language);
    if (indexOfLanguage != -1) languages.RemoveAt(indexOfLanguage);
    return languages;
  }

  public static bool IsUnique(List<string> languages)
  {
    Dictionary<string, int> hashMap = new Dictionary<string, int>();
    foreach (string language in languages)
    {
      bool isPresent = hashMap.ContainsKey(language);
      if (isPresent) hashMap[language] += 1;
      else hashMap.Add(language, 1);
      if (hashMap[language] > 1) return false;
    }

    return true;
  }
}
