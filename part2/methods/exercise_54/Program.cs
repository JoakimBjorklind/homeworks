using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      {
        int beginning = Convert.ToInt32(Console.ReadLine()); 
        int end = Convert.ToInt32(Console.ReadLine()); 
        
        DivisibleByThreeInRange(beginning, end);

      }

    }

    // Write your method here:
    
    public static void DivisibleByThreeInRange(int beginning, int end)

    {
      while (beginning <= end)
      {

      if (beginning % 3 == 0)
      {
        Console.WriteLine(beginning); 
      }
      beginning++;
      }
      



    }

  


  }
}
