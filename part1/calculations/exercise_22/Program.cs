using System;

namespace exercise_22
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
      Console.WriteLine("Give the third number!");
      string num3 = Console.ReadLine();
      int intValue3 = Convert.ToInt32(num3);
      double average = (intValue + intValue2 + intValue3) / 3.0;
      Console.WriteLine("The average is " + average);

      


    }
  }
}
