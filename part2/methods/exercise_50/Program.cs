using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      Console.WriteLine("How many times?");
      int num = Convert.ToInt32(Console.ReadLine());
      int number = 0;
      
      while (num > number)

      {
        PrintPhrase();
        number++;
      }


 
    }

    // Write your method here:
    public static void PrintPhrase() 
    {
      Console.WriteLine("In a hole in the ground there lived a method");
    }
    
  }
}
