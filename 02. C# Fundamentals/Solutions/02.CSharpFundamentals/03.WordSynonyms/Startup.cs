namespace _03.WordSynonyms
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            var wordSynonyms = new Dictionary<string, List<string>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordSynonyms.ContainsKey(word))
                {
                    wordSynonyms.Add(word, new List<string>());
                }

                wordSynonyms[word].Add(synonym);
            }

            foreach (var word in wordSynonyms)
            {
                Console.WriteLine(word.Key + " - " + string.Join(", ", word.Value));
            }
        }
    }
}
