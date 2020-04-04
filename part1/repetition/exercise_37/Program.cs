using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      
      // Write your code here:

      int countNumbers = 0;
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
          countNumbers = countNumbers + 1;
        }       
      }

       Console.WriteLine("Total amount of numbers: " + countNumbers);
      

    }
  }
}
