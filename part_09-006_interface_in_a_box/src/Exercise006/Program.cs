namespace Exercise006
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book("Fedor Dostojevski", "Crime and Punishment", 1866);
            Book book2 = new Book("Robert Martin", "Clean Code", 2008);
            Book book3 = new Book("Kent Beck", "Test Driven Development", 2000);

            Box bookBox = new Box(1);
            bookBox.Add(book1);
            bookBox.Add(book2);
            bookBox.Add(book3);

            Console.WriteLine(bookBox);



        }
    }
}