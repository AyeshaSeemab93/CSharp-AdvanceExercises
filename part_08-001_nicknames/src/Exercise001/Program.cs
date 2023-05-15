using System.Collections.Generic;
namespace Exercise001
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            //creating dictionary object and adding data to it (class of dictionary object is present by default.)
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("matthew", "matt"); //
            dict.Add("michael", "mix");
            dict.Add("arthur", "artie");

            /*We use keyvaluePair object to print dictionary object*/
            foreach (KeyValuePair<string, string> dictionary in dict)
            {
                // Console.WriteLine(dictionary.Key + "'s nickname is " + dictionary.Value);

                // Method 2: string Interpolatio

                Console.WriteLine("{0}'s nickname is {1}", dictionary.Key, dictionary.Value);
            }

        }
    }
}
