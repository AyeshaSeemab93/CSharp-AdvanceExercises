namespace Exercise008
{
    using System;
    using System.Collections.Generic;
    public class DictionaryOfManyTranslations
    {
        public Dictionary<string, List<string>> translations;

        public DictionaryOfManyTranslations()
        {
            this.translations = new Dictionary<string, List<string>>();
        }

        public void Add(string word, string translation)
        {
            if (translations.ContainsKey(word))
            {
                translations[word].Add(translation);

            }
            else
            {
                translations.Add(word, new List<string>());  //OR translations[word] = new List<string>()
                translations[word].Add(translation);
            }
        }
        public List<string> Translate(string word)
        {
            if (!translations.ContainsKey(word))
            {
                return translations.Add(word, new List<string>()); //RETURNING EMPTY LIST
            }
            return translations[word]; // RETURNING LIST OF TRANSLATIONS TO THE WORD
        }
        public void Remove(string word)
        {
            translations.Remove(word);
        }
    }
}