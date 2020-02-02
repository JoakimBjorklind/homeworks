using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
      ChristmasTree(4);
    }

    public static void PrintStars(int number)
    {
       for (int i = 0; i < number; i++)
      {
        Console.Write("*");
      }      
      Console.WriteLine("");   
      
    }

    public static void PrintSpaces(int number)
    {
      for (int i = 0; i < number; i++)
      {
        Console.Write(" ");
      }      
      
    }

    public static void PrintRightTriangle(int size)
    {
       
      int left = size -1;
      for (int i = 1; i <= size; i++)
      {
        PrintSpaces(left);
        PrintStars(i);
        left--;
      }    
    
    }

    public static void ChristmasTree(int height)
    {
      int left = height -1;
      
      for (int i = 1; i <= height; i++)
      {
        
        PrintSpaces(left);
        PrintStars(i);
        left--;
        
        
        
          
      }

        
    }
  }
}
