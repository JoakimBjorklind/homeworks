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
                
                

                
                while (true)
                {
                    string asked = Console.ReadLine();
                    if (asked == "")
                    {
                        break;
                    }
                    string[] parts = asked.Split(",");
                   
                    
                    if (name.Length < parts[0].Length)
                    {
                        name = parts[0];
                    }
                    
                    // I used the following formula to get the age of the oldest person.
                    if (Convert.ToInt32(parts[1]) > oldest)
                    {
                        oldest = 2020 - Convert.ToInt32(parts[1]);
                        

                    }
                    
                }
                Console.WriteLine("Longest name: " + name);
                Console.WriteLine("Highest age: " + oldest);
                







            }
        
    }
}


