using System;
using System.Collections.Generic;

namespace exercise_112
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<TelevisionProgram> list = new List<TelevisionProgram>();

            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }

                Console.Write("Duration: ");
                string duration = Console.ReadLine();
                int duration2 = Convert.ToInt32(duration);
                

               
                list.Add(new TelevisionProgram(name, duration2));


            }
            Console.WriteLine();
            Console.Write("Program's maximum duration? ");
            string askDuration = Console.ReadLine();
            int askDuration2 = Convert.ToInt32(askDuration);

            
            foreach (TelevisionProgram item in list)
            {
              if (item.duration <= askDuration2)
              {
                 Console.WriteLine(item);
              }

            }



           
        }
    }
}



