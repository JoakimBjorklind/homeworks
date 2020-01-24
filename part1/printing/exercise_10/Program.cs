using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give a name for main character:");
            
            string name = Console.ReadLine();
            Console.WriteLine("Give the character a proffesion:");
            string proff = Console.ReadLine();

            Console.WriteLine("Here is the story:");
            Console.WriteLine("Once upon a time there was a " + proff + " called " + name);
            Console.WriteLine("On her way to work, " + name + " often pondered what being " + proff + " meant to them.");
            Console.WriteLine("When you work as a " + proff + " you meet interesting people.");
            Console.WriteLine(name + " enjoys their work as " + proff + ", The end.");

        }
    }
}
