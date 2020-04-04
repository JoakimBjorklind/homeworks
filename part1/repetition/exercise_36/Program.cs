using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      while(true)

      {
        Console.WriteLine("Give a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 0)
        {
          break;
        }

        else if (num < 0)

        {
          Console.WriteLine("That is negative");
        }

        else
        {
          Console.WriteLine(num * num);
        }

        

        
      }



    }
  }
}
