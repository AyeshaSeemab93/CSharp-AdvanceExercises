namespace Exercise006
{
    using System;
    using System.Collections.Generic;

    public class Book : IPackable
    {
        public string author;
        public string bookName;
        public int year;
        public int weight;

        public Book(string author, string bookName, int year)
        {
            this.author = author;
            this.bookName = bookName;
            this.year = year;
            this.weight = 1;
        }

        public int Weight()
        {
            return this.weight;
        }

        public override string ToString()
        {
            return this.author + ": " + this.bookName + " (" + this.year + ")";
        }
    }
}