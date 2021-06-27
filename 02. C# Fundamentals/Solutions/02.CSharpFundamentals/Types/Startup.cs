namespace Types
{
    using System;
    using System.Text.RegularExpressions;

    public static class Startup
    {
        public static void Main()
        {
            var regex = new Regex(@"[a]"); // Match the symbol 'a'
            var firstRegex = new Regex(@"[a-z]"); // Match a small letter
            var secondRegex = new Regex(@"[A-Z]"); // Match a capital letter
            var thirdRegex = new Regex(@"[0-9]"); // Match a digit
            var forthRegex = new Regex(@"[a-z]{2}"); // Match 2 small letters
            var fifthRegex = new Regex(@"[A-Z][a-z]+"); // Match a capital letter and all small letters before anything else.
            var sixthRegex = new Regex(@"[A-Z][a-z]+(?<dividers>{,\\/*})"); // Create a group and set a name to it.
        }
    }
}
