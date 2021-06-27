namespace ContainsMethod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            List<string> names = new List<string>() { "Stephie", "Nikolay", "Pesho", "Gosho" };

            if (names.Contains("Nikolay")) // Check if there is position with value "Nikolay"
            {
                Console.WriteLine("Nikolay will be examined.");
            }
            else
            {
                Console.WriteLine("Find another person.");
            }
        }
    }
}
