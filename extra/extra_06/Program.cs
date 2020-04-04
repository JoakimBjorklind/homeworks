using System;

namespace extra_06
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      int num1 = Convert.ToInt32(Console.ReadLine());
      int num2 = Convert.ToInt32(Console.ReadLine());
      int sum = num1 + num2;
      if (sum >= 0)
      {
        Console.WriteLine(Math.Sqrt(sum));
      }
      else
      {
        Console.WriteLine(0);
      }
    }
  }
}
