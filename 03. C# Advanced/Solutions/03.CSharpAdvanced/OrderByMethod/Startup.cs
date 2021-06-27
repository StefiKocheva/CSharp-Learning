namespace OrderByMethod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            List<string> names = new List<string>() { "Stephie", "Nikolay", "Pesho", "Gosho" };

            names = names.OrderBy(name => name).ToList(); // Order by alphabetically ascending (A-Z)

            names = names.OrderByDescending(name => name).ToList(); // Order by alphabetically desending (Z-A)

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
