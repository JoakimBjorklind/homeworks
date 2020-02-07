using System;
using System.Collections.Generic;

namespace exercise_92
{
    class Program
    {
        public static void Main(string[] args)
        
            {
                List<string> persons = new List<string>();

                int oldest = 0;
                string name = "";
                int length = name.Length;
                

                
                while (true)
                {
                    string asked = Console.ReadLine();
                    if (asked == "")
                    {
                        break;
                    }
                    string[] parts = asked.Split(",");
                   
                    // did not know how to get this part.
                    if ( )
                    {
                        
                    }
                    
                    // I used the following formula to get the age of the oldest person.
                    if (Convert.ToInt32(parts[1]) > oldest)
                    {
                        oldest = 2020 -  Convert.ToInt32(parts[1]);
                        

                    }
                    
                }
                Console.WriteLine("Longest name: " + name);
                Console.WriteLine("Highest age: " + oldest);
                







            }
        
    }
}


