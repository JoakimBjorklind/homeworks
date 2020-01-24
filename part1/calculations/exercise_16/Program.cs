using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("How many days?");
      string num = Console.ReadLine();
      int intValue = Convert.ToInt32(num);
      Console.WriteLine(intValue*86400);


    }
  }
}
