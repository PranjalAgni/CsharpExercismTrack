using System;
using System.Collections.Generic;

namespace CsharpExercismTrack
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine($"Hi 😀 {HelloWorld.Hello()}");
      var languages = new List<string>();
      languages.Add("C#");
      languages.Add("Clojure");
      languages.Add("Elm");
      Console.WriteLine(Languages.IsUnique(languages));
    }
  }
}
