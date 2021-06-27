namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            Dictionary<string, int> oddOccurences = new Dictionary<string, int>();

            var input = Console
                .ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string currentValue = input[i].ToLower();

                if (!oddOccurences.ContainsKey(currentValue))
                {
                    oddOccurences.Add(currentValue, 1);
                }
                else
                {
                    oddOccurences[currentValue]++;
                }
            }

            foreach (var item in oddOccurences)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
