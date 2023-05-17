namespace Exercise004
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            Book senseAndSensibility = new Book("Sense and Sensibility", 1811, "...");
            Book prideAndPrejudice = new Book("Pride and Prejudice", 1813, "....");

            Dictionary<string, Book> books = new Dictionary<string, Book>();

            books.Add(senseAndSensibility.name, senseAndSensibility);
            books.Add(prideAndPrejudice.name, prideAndPrejudice);

            PrintValues(books);
            Console.WriteLine("-- -- -- --");
            PrintValueIfNameContains(books, "prejud");




        }
        public static void PrintValues(Dictionary<string, Book> dictionary)
        {
            //Method 1 keyValuepair
            foreach (KeyValuePair<string, Book> kpv in dictionary)
            {
                Console.WriteLine(kpv.Value);
            }


            // Method 2 Going Through A Dictionary's Values
            // Dictionary<string, Book>.ValueCollection values = dictionary.Values;
            // foreach (Book book in values)
            // {
            //     Console.WriteLine(book.ToString());
            // }

        }
        public static void PrintValueIfNameContains(Dictionary<string, Book> dictionary, string text)
        {

            string lower = text.ToLower();
            string upper = text.ToUpper();

            foreach (KeyValuePair<string, Book> item in dictionary)
            {
                // FINDING NAME IN KEYS BEC ITS ALSO (BOOK.NAME)
                if (item.Key.ToLower().Contains(text) || item.Key.Contains(text))
                {
                    Console.WriteLine(item.Key);
                }

                // FINDING NAME IN VALUES
                // if (item.Value.name.ToLower().Contains(text) || item.Value.name.Contains(text))
                // {
                //     Console.WriteLine(item.Value);
                // }



            }

        }

    }
}