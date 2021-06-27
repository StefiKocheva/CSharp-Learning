namespace BasicOperationsInSet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            HashSet<string> names = new HashSet<string>();

            names.Add("Stephie"); // names: { "Stephie" } 

            names.Add("Nikolay"); // names: { "Stephie", "Nikolay" }

            names.Add("Stephie"); // names: { "Stephie", "Nikolay" }

            names.Remove("Nikolay"); // names: { "Stephie" } 

            names.Add("Nikolay"); // names: { "Stephie", "Nikolay" }

            names.Add("Nikolay"); // names: { "Stephie", "Nikolay" }

            names.Contains("Ivan"); // false

            Console.WriteLine(names.Count); // 2 
        }
    }
}
