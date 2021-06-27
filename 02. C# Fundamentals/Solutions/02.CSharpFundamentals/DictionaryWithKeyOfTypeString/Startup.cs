namespace DictionaryWithKeyOfTypeString
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            Dictionary<string, double> grades = new Dictionary<string, double>();
            SortedDictionary<string, double> sortedGrades = new SortedDictionary<string, double>();

            grades["Stefani"] = 2; // Set a value to a key which is of type string.
            grades["Nikolay"] = 6;

            sortedGrades["Stefani"] = 2;
            sortedGrades["Nikolay"] = 6;

            Console.WriteLine(grades["Stefani"]);
        }
    }
}
