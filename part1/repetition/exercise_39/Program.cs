﻿using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int summa = 0; 
      while (true)
      {
        
        Console.WriteLine("Give a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number == 0)
        {
          break;
        }
        else 
        {
          summa += number;
        } 
        

      }

       Console.WriteLine("Total sum of numbers: " + summa);


    }
  }
}
