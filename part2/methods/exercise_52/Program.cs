using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      int number = Convert.ToInt32(Console.ReadLine());     
      PrintFromNumberToOne(number);


    }

    // Write your method here:
    public static void PrintFromNumberToOne(int amount)

    {
      for (int i=amount;1<=i;i--)

      {
        Console.WriteLine(i);
      } 
    }  


  }
}
