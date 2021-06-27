namespace _01.MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    public static class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            var result = regex.Matches(input);

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
