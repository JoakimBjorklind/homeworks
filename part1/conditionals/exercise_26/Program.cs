using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your age:");
      string num = Console.ReadLine();
      int intValue = Convert.ToInt32(num);

      if (intValue < 1900)

      {
        Console.WriteLine("You're old");
      }

    


    }
  }
}
