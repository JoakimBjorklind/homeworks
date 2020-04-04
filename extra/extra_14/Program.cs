using System;
using System.IO;

namespace extra_14
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            string[] lines = File.ReadAllLines("text.txt");

            
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }


        }
    }
}
