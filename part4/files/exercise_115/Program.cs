using System;

namespace exercise_115
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                int number = Convert.ToInt32(input);
                int product = number * number * number;
                Console.WriteLine(product);
            }

        }
    }
}
