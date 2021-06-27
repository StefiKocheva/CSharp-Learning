namespace SortedSets
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            SortedSet<string> names = new SortedSet<string>();

            names.Add("Stephie"); // names: { "Stephie" } 

            names.Add("Nikolay"); // names: { "Nikolay", "Stephie" }
        }
    }
}
