namespace _04.TextFilter
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            string[] banWords = Console
                .ReadLine()
                .Split(", ")
                .ToArray();

            string text = Console.ReadLine();

            for (int i = 0; i < banWords.Length; i++)
            {
                text = text.Replace(banWords[i], new string('*', banWords[i].Length)); // new string "*****"
            }

            Console.WriteLine(text);
        }
    }
}
