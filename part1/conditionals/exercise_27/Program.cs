using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string num = Console.ReadLine();
      int intValue = Convert.ToInt32(num);

      if (intValue > 0)

      {
        Console.WriteLine("It is positive");
      }

      if (intValue <= 0)

      {
        Console.WriteLine("It is not positive");
      }




    }
  }
}
