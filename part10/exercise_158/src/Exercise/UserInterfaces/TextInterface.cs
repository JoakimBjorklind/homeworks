namespace Exercise
{
    using System;
    using System.Collections.Generic;
    public class TextInterface
    {
        // Create the userinterface here
        private List<Book> books;
        public TextInterface()
        {
            this.books = new List<Book>();
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Input the name of the book, empty stops: ");
                string book = Console.ReadLine();
                if (book == "")
                {
                    break;
                }
                Console.WriteLine("Input the age recommendation:");
                int recommendation = Convert.ToInt32(Console.ReadLine());



                this.books.Add(new Book(book, recommendation));
            }
            Console.WriteLine(this.books.Count + " books in total.");
            Console.WriteLine();
            this.books.Sort();
            Console.WriteLine("Books:");
            foreach (Book b in books)
            {
                Console.WriteLine(b);
            }
        }
    }
}