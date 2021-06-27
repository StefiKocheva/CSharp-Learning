namespace _03.MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    public static class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\b([0-9]{2})([-.\/])([A-Z][a-z]{2})\2([0-9]{4})\b");

            var result = regex.Matches(input);

            foreach (Match item in result) 
            {
                Console.WriteLine($"Day: {item.Groups[1].Value}, Month: {item.Groups[3].Value}, Day: {item.Groups[4].Value}");
            }
        }
    }
}
