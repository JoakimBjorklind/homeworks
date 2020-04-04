using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string num = Console.ReadLine();
      int intValue = Convert.ToInt32(num);
      Console.WriteLine("Give the second number!");
      string numm = Console.ReadLine();
      int intValuee = Convert.ToInt32(numm);
      Console.WriteLine("The sum is " + (intValue + intValuee));
      

      
    }
  }
}
