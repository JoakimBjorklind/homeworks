using System;
using System.Collections.Generic;

namespace exercise_67
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
       var item = list[0];
       var item2 = list[list.Count -1];

       Console.WriteLine(item);
       Console.WriteLine(item2);

    }
  }
}
