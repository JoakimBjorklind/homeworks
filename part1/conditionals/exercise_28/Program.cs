using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("How old are you?");
      string num = Console.ReadLine();
      int intValue = Convert.ToInt32(num);

      if (intValue >= 18)

      {
        Console.WriteLine("You're an adult!");
      }

      if (intValue < 18)

      {
        Console.WriteLine("You're under age!");
      }



    }
  }
}
