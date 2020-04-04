using System;
using System.IO;

namespace exercise_116
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Read the file data.txt and print the text from it as it is
            // You can use either File.ReadAllText or File.ReadAllLines
            
            string[] lines = File.ReadAllLines("data.txt");

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
            Console.WriteLine(lines[3]);

        }
    }
}
