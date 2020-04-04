using System;
using System.Collections.Generic;

namespace exercise_69
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine("From where?");
      int num1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where to?");
      int num2 = Convert.ToInt32(Console.ReadLine());

      for (int i = 0; i < list.Count; i++) 
      {
        int number = list[i];
        
        if(num1 <= number && num2 >= number)
        Console.WriteLine(number);
    
      }
      
      
     




    }
  }
}
