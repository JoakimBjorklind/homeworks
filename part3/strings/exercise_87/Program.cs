using System;
using System.Collections.Generic;

namespace exercise_87
{
    class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                string text = Console.ReadLine();
                if (text == "")
                {
                    break;
                }
                string[] parts = text.Split(" ");

                foreach (string line in parts)

                    if (line.Contains("av"))
                    {

                        Console.WriteLine(line);
                    }



            } 
        }

    }

}

