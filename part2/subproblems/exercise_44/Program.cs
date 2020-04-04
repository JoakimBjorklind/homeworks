using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int num = Convert.ToInt32(Console.ReadLine());
      int num2 = Convert.ToInt32(Console.ReadLine());

      if (num > num2)

      {
        Console.WriteLine(num + " is greater than " + num2 + ".");
      }

      else if (num < num2)

      {
        Console.WriteLine(num + " is less than " + num2 + ".");
      }

      else

      {
        Console.WriteLine(num + " is equal to " + num2 + ".");
      }

    
      



    }
  }
}
