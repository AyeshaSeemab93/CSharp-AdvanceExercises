namespace Exercise005
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    public class SaveableDictionary
    {
        public string file;
        public Dictionary<string, string> dict;

        public SaveableDictionary()
        {
            this.dict = new Dictionary<string, string>();
        }
        public SaveableDictionary(string file)
        {
            this.file = file;
            this.dict = new Dictionary<string, string>();
            Load();


        }
        public void Add(string word, string translation)
        {
            if (dict.ContainsKey(word))
            {
                return;
            }
            else
            {
                dict.Add(word, translation);
            }
        }
        public string Translate(string word)
        {
            //for checking in all keys
            if (dict.ContainsKey(word))
            {
                return dict[word];
            }
            else
            {
                //for checking in all values
                foreach (KeyValuePair<string, string> kpv in this.dict)
                    if (kpv.Value.Contains(word))
                    {
                        return kpv.Key;
                    }
            }

            return null;
        }
        public void Delete(string word)
        {


            foreach (KeyValuePair<string, string> kpv in this.dict)
            {
                if (kpv.Key.Contains(word) || kpv.Value.Contains(word))
                {
                    dict.Remove(kpv.Key);
                }

            }
        }

        public bool Load()
        {
            try
            {

                string[] lines = File.ReadAllLines(this.file);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(":");

                    // dict.Add(parts[0], parts[1]);
                    if (parts.Length == 2)
                    {
                        string word = parts[0].Trim();
                        string translation = parts[1].Trim();

                        dict[word] = translation;


                    }

                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool Save()
        {
            try
            {
                if (File.Exists(this.file))
                {
                    StreamWriter writer = new StreamWriter(this.file);

                    foreach (KeyValuePair<string, string> kpv in this.dict)
                    {
                        writer.WriteLine(kpv.Key + ":" + kpv.Value);

                    }
                    writer.Close();

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
