using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give numbers:");
      int summa = 0;
      int validNumbers = 0;
      int countEven = 0;
      int countOdd = 0;
      
      while (true)
      {
        int number = Convert.ToInt32(Console.ReadLine());

        if (number == -1) {
          break;
        }
        summa += number;
        validNumbers++;

        if (number % 2 == 0)

        {
          countEven = countEven + 1;
        }

        if (number % 2 == 1)

        {
          countOdd = countOdd + 1;
        }
        
        
        
      }
      double average = ((double)summa / validNumbers);


      Console.WriteLine("Thx! Bye!");
      Console.WriteLine("Sum: " + summa);
      Console.WriteLine("Numbers: " + validNumbers);
      Console.WriteLine("Average: " + average);
      Console.WriteLine("Even: " + countEven);
      Console.WriteLine("Odd: " + countOdd);
     
  



      
      


 
    }
  }
}
