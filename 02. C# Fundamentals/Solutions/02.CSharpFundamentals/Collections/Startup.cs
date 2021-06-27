namespace Collections
{
    using System;
    using System.Text.RegularExpressions;

    public static class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var phoneNumberRegex = new Regex(@"[0-9]{3} [0-9]{3} [0-9]{4}"); // *** *** ****

            MatchCollection matches = phoneNumberRegex.Matches(input); // Get all matches in the input.

            // You could iterate the MatchCollection with foreach.
        }
    }
}
