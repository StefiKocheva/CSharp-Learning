namespace _03.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public static class Startup
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt").ToLower().Split();
            var text = File.ReadAllText("text.txt").ToLower();

            var occurencies = new Dictionary<string, int>();

            foreach (var word in words)
            {
                var regex = new Regex(@$"\b{word}\b");

                var count = regex.Matches(text).Count;

                occurencies.Add(word, count);
            }

            occurencies = occurencies.OrderByDescending(o => o.Value).ToDictionary(o => o.Key, o => o.Value);

            foreach (var (key, value) in occurencies)
            {
                File.AppendAllText("Output.txt", $"{key} - {value}" + Environment.NewLine);
            }
        }
    }
}
