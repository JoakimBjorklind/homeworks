using System;
using System.Collections.Generic;

namespace extra_13
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            List<Person> kindergarden = new List<Person>();

            // Read the names of persons from the user
            while (true)
            {

                string kids = Console.ReadLine();
                if (kids == "")
                {
                    break;
                }

                string[] parts = kids.Split(",");
                string name = parts[0];
                int age = Convert.ToInt32(parts[1]);
                kindergarden.Add(new Person(name, age));
            }
            foreach (Person child in kindergarden)
            {
                Console.WriteLine(child);
            }

        }
    }
}
