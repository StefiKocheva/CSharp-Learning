namespace HashSets
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            List<string> names = new List<string>();
            HashSet<string> namesSet = new HashSet<string>(); // Initialize a new set.

            names.Add("Stephie"); // names: { "Stephie" }
            namesSet.Add("Stephie"); // namesSet: { "Stephie" } -> Add value to the set.

            names.Add("Nikolay"); // names: { "Stephie", "Nikolay" }
            namesSet.Add("Nikolay"); // namesSet: { "Stephie", "Nikolay" } -> Add value to the set.

            names.Add("Stephie"); // names: { "Stephie", "Nikolay", "Stephie" }
            namesSet.Add("Stephie"); // namesSet: { "Stephie", "Nikolay" } -> Don't add value to the set, because there is already the same in.
        }
    }
}
