using System;

namespace extra_03
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            Console.WriteLine("How many numbers?");
            int howMany = Convert.ToInt32(Console.ReadLine());
            int number = 0;

            while (howMany > number)
            {
                number++;
            }
            Console.WriteLine("Give " + howMany + " numbers:");
            int summa = 0;
            int total = 1;
            int valid = 0;
            for(int i = 0; i < howMany; i++)
            {
              int num = Convert.ToInt32(Console.ReadLine());
              summa += num;
              total *= num;
              valid++;
            }
            double average = ((double)summa / valid);

            Console.WriteLine("Their sum: " + summa);
            Console.WriteLine("Their total: " + total);
            Console.WriteLine("Their average: " + average);



        }
    }
}
