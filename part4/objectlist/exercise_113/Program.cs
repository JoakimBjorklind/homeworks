using System;
using System.Collections.Generic;

namespace exercise_113
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            // Remember also to create the file Book.cs and class in it!
            List<Book> list = new List<Book>();
            
            while (true)
            {
                Console.Write("Name: ");
                string title = Console.ReadLine();
                if (title == "")
                {
                    break;
                }

                Console.Write("Pages: ");
                int pages = Convert.ToInt32(Console.ReadLine());
                Console.Write("Publication year: ");
                int publication = Convert.ToInt32(Console.ReadLine());

                list.Add(new Book(title, pages, publication));
            }
            Console.WriteLine();
            Console.Write("What information will be printed? ");
            string askAbout = Console.ReadLine();

            foreach (Book item in list)
            {
              if (askAbout == "everything")
              {
                Console.WriteLine(item);
              }
              else if (askAbout == "title")
              {
                Console.WriteLine(item.title);
              }
              
              
            }
            



        }
    }
}




