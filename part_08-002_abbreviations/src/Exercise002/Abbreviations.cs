using System.Collections.Generic;
namespace Exercise002
{
    using System;
    public class Abbreviations
    {
        Dictionary<string, string> dict;
        public Abbreviations()
        {
            this.dict = new Dictionary<string, string>();

        }
        public void AddAbbreviation(string abbreviation, string explaination)
        {

            dict.Add(abbreviation, explaination);

        }

        public string FindExplanationFor(string abbreviation)
        {
            if (this.HasAbbreviation(abbreviation))
            {
                return dict[abbreviation]; //asking for all info by typing the keyname
            }
            else
            {
                return "not found";
            }
        }

        // Helper method
        public bool HasAbbreviation(string abbreviation)
        {
            if (dict.ContainsKey(abbreviation))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}