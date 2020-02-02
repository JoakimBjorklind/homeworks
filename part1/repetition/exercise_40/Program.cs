using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int summa = 0;
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
          summa += number;
          countNumbers = countNumbers + 1;
        } 
        

      }

       Console.WriteLine("Total sum of numbers: " + summa);
       Console.WriteLine("Total amount of numbers: " + countNumbers);


    }
  }
}
