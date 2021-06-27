namespace _02.RepeatStrings
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            string concatenatedString = string.Empty;

            string[] words = Console
                .ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                int length = words[i].Length;

                for (int j = 0; j < length; j++)
                {
                    concatenatedString += words[i];
                }
            }

            Console.WriteLine(concatenatedString);
        }
    }
}
