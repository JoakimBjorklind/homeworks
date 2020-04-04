using System;

namespace extra_11
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            Console.WriteLine("Give a sentence:");
            string sentence = Console.ReadLine();

            string[] parts = sentence.Split(" ");

            foreach (string line in parts)
            {
                Console.WriteLine(line);
            }


        }
    }
}
