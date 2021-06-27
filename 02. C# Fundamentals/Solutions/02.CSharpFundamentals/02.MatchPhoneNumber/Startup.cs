namespace _02.MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;

    public static class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\+359([ -])2\1[0-9]{3}\1[0-9]{4}\b");

            var result = regex.Matches(input);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
