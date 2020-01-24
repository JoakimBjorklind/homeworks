using System;

namespace exercise_19
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
      string num2 = Console.ReadLine();
      int intValue2 = Convert.ToInt32(num2);
      Console.WriteLine(intValue + intValue2 + (intValue + intValue2));



    }
  }
}
