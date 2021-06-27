namespace _02.RandomizeWords
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split();

            Random item = new Random();

            for (int num1 = 0; num1 < words.Length; num1++)
            {
                int num2 = item.Next(0, words.Length);

                string num = words[num1];

                words[num1] = words[num2];

                words[num2] = num;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
