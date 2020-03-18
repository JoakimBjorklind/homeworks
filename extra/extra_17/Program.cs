using System;
using System.Collections.Generic;

namespace extra_17
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Add your code here:
            List<Item> items = new List<Item>();

           
            while (true)
            {
                Console.WriteLine("Identifier? (empty will stop):");
                string identifier = (Console.ReadLine());
                if (identifier == "")
                {
                    break;
                }


                Console.WriteLine("Name? (empty will stop):");
                string name = Console.ReadLine();


                if (name == "")
                {
                    break;
                }
                Item item = new Item(identifier, name);
                if (items.Contains(item))
                {
                    continue;
                }
                else
                {
                    items.Add(item);
                }

            }

            
            Console.WriteLine("==Items==");
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
