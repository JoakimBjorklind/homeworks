﻿using System;
using System.Collections.Generic;

namespace extra_09
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      List<string> list = new List<string>() { "This is a string", "This is magic", "THIS IS PATRICK!" };

      int index = 0;

      while(index < list.Count)
      {
        Console.WriteLine(list[index]);
        index = index + 1;
      }
      
      for(int i = 0; i < list.Count; i++)
      {
        Console.WriteLine(list[i]);
      }

      foreach(string word in list)
      {
        Console.WriteLine(word);
      }


    }
  }
}
