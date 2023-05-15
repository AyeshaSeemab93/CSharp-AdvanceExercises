using System.Collections.Generic;
namespace Exercise002
{
    using System;
    public class Abbrevations
    {
        Dictionary<string, string> dict;
        public Abbrevations()
        {
            this.dict = new Dictionary<string, string>();

        }
        public void AddAbbrevation(string abbrevation, string explanation)
        {

            dict.Add(abbrevation, explanation);

        }

        // Helper method
        public bool HasAbbrevation(string abbrevation)
        {
            if (dict.ContainsKey(abbrevation))
            {
                return true;
            }
            else false;
        }

    }
}