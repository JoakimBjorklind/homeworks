﻿using System;

namespace extra_10
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      
      // You can test your method here
      int[] array = { 5, 1, 3, 4, 2 };
      PrintArrayInStars(array);

    }

    public static void PrintArrayInStars(int[] array)
    {
      for (int i = 0; i < array.Length; i++)
            {
                int x = array[i];
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            

    }
  }
}
