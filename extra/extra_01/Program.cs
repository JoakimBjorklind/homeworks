using System;

namespace extra_01
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            Console.WriteLine("What do you want to print?");
            string asked = Console.ReadLine();
            Console.WriteLine("How many times do you want to print?");
            int howMany = Convert.ToInt32(Console.ReadLine());
            int number = 0;

            while (howMany > number)

            {
               Console.WriteLine(asked);
               number++;
            }
        


        }
        
    }
}
