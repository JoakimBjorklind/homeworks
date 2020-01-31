using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      int num = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
      int num2 = Convert.ToInt32(Console.ReadLine());

      for (int number = num2; number <= num; number++)
      {
        if ( number < num2)
        {
          continue;
        }
        else
        Console.WriteLine(number);
      }

      

     


      
    }
  }
}
