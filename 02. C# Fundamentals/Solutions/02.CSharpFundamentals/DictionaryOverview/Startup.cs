namespace DictionaryOverview
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            Dictionary<int, string> daysOfWeek = new Dictionary<int, string>(); // Create a new Dictionary<TKey, TValue>.
            daysOfWeek[4] = "Friday"; // Set a value to a key.
            daysOfWeek[0] = "Monday";

            Console.WriteLine(daysOfWeek[4]);
        }
    }
}
