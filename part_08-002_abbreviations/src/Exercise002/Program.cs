namespace Exercise002
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            //making object for class
            Abbreviations abbreviations = new Abbreviations();
            //calling methods from class to add data
            abbreviations.AddAbbreviation("e.g", "for example");
            abbreviations.AddAbbreviation("etc.", "and so on");
            abbreviations.AddAbbreviation("i.e", "more precisely");

            //asking for all abbrevations in a single variable:
            string text = "e.g i.e etc. lol";
            //using split to seperate each abbrecation
            foreach (string part in text.Split(" "))
            {
                Console.WriteLine(abbreviations.FindExplanationFor(part));
            }
        }
    }
}