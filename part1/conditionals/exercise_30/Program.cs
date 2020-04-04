using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your percent [0 - 100]:");
      string num = Console.ReadLine();
      int intValue = Convert.ToInt32(num);

      if (intValue < 0)

      {
        Console.WriteLine("Impossible");
      }

      else if (intValue >= 0 && intValue <= 49)

      {
        Console.WriteLine("Fail");
      }

      else if (intValue >= 50 && intValue <= 59)

      {
        Console.WriteLine("Grade: 1");
      }

      else if (intValue >= 60 && intValue <= 69)

      {
        Console.WriteLine("Grade: 2");
      }

      else if (intValue >= 70 && intValue <= 79)

      {
        Console.WriteLine("Grade: 3");
      }

      else if (intValue >= 80 && intValue <= 89)

      {
        Console.WriteLine("Grade: 4");
      }

      else if (intValue >= 90 && intValue <= 100)

      {
        Console.WriteLine("Grade: 5");
      }

      else 

      {
        Console.WriteLine("Outstanding!");
      }












    }
  }
}
