﻿using System;
using System.Collections.Generic;

namespace exercise_89
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string asked = Console.ReadLine();
                if (asked == "")
                {
                    break;
                }
                string[] parts = asked.Split(" ");

                foreach (string line in parts)
                {


                }
                Console.WriteLine(parts[parts.Length-1]);


            }

        }
    }
}



