namespace _07.RepeatString
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int count = int.Parse(Console.ReadLine());

            string final = GetFinalString(input, count);

            Console.WriteLine(final);
        }

        private static string GetFinalString(string str, int counter)
        {
            string finalString = "";

            for (int i = 0; i < counter; i++)
            {
                finalString += str;
            }

            return finalString;
        }
    }
}
