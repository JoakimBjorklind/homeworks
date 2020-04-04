using System;
using System.IO;


namespace exercise_119
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create new timer
            Timer timer = new Timer();
            // Loop until you cancel the loop.
            // You can cancel with the CTRL + C
            while (true)
            {
                Console.WriteLine(timer);
                timer.Advance();
                

            }
        }
    }
}