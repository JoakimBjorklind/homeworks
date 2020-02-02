using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number: ");
      string num = Console.ReadLine();
      int intValue = Convert.ToInt32(num);

      if (intValue % 2 == 0)
      
      {
        Console.WriteLine("It is even.");
      }

      if (intValue % 2 == 1)

      {
         Console.WriteLine("It is odd.");
      }


    }
  }
}
