using System.Collections.Generic;
namespace Exercise003
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("f.e", "for example");
            dict.Add("etc.", "and so on");
            dict.Add("i.e", "more precisely");

            PrintKeys(dict);
            Console.WriteLine("---");
            PrintKeysWhere(dict, "i");
            Console.WriteLine("---");
            PrintValuesOfKeysWhere(dict, ".e");
        }

        public static void PrintKeys(Dictionary<string, string> dict)
        {
            Dictionary<string, string>.KeyCollection keys = dict.Keys;
            //To print dictionary use foreach and keyValuepair object
            foreach (KeyValuePair<string, string> kpv in dict)
            {
                Console.WriteLine("{0}", kpv.Key);
            }
        }
        public static void PrintKeysWhere(Dictionary<string, string> dict, string text)
        {
            Dictionary<string, string>.KeyCollection keys = dict.Keys;
            foreach (string key in keys)
            {
                if (key.Contains(text))
                {
                    Console.WriteLine(key);
                }

            }
        }
        public static void PrintValuesOfKeysWhere(Dictionary<string, string> dict, string text)
        {
            Dictionary<string, string>.KeyCollection keys = dict.Keys;
            foreach (string key in keys)
            {
                if (key.Contains(text))
                {
                    Console.WriteLine(dict[key]);
                }
            }


        }


    }
}