namespace Exercise003
{
    using System;
    using System.Collections.Generic;
    public class TextInterface
    {
        List<Book> books;

        public TextInterface()
        {
            this.books = new List<Book>();
        }
        public void Input()
        {
            while (true)
            {
                Console.WriteLine("Input the name of the book, empty stops:");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                Console.WriteLine("Input the age recommendation:");
                int age = Convert.ToInt32(Console.ReadLine());
                Book book = new Book(name, age);
                books.Add(book);

            }
        }
        public void Start()
        {
            Input();
            Console.WriteLine();
            Console.WriteLine(books.Count + " books in total.");
            Console.WriteLine();
            Console.WriteLine("Books:");
            books.Sort();
            foreach (Book book in books)
            {
                Console.WriteLine(book.name + " (recommended for " + book.ageRecommendation + " year-olds or older)");
            }

        }
    }

}