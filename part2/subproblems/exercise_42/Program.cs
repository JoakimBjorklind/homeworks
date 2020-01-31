using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int num = Convert.ToInt32(Console.ReadLine());
      int num2 = Convert.ToInt32(Console.ReadLine());
      int sum = num + num2;
      double squareRoot = Math.Sqrt(sum);
      Console.WriteLine(squareRoot);

    
    }
  }
}
