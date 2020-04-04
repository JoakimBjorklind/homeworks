using System;
using System.Collections.Generic;

namespace exercise_92
{
    class Program
    {
        public static void Main(string[] args)
        
            {
                List<string> persons = new List<string>();

                int oldest = 2020;
                string name = "";
                int age = 0;
                int length = 0;
                int lengthName = 0;

                
                

                
                while (true)
                {
                    string asked = Console.ReadLine();
                    if (asked == "")
                    {
                        break;
                    }
                    string[] parts = asked.Split(",");
                   
                    string word = parts[0];
                    length = word.Length;
                    if (lengthName < length)
                    {
                        lengthName = length;
                        name = parts[0];
                    }
                    
                    
                    if (Convert.ToInt32(parts[1]) < oldest)
                    {
                        oldest = Convert.ToInt32(parts[1]);
                        

                    }
                    
                }
                age = 2020 - oldest;
                Console.WriteLine("Longest name: " + name);
                Console.WriteLine("Highest age: " + age);
                







            }
        
    }
}


