namespace RemoveAtMethod
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            List<string> names = new List<string>() { "Stephie", "Nikolay", "Pesho", "Gosho" }; // Declaring a new list

            names.RemoveAt(names.Count - 1); // Remove the element on given position.

            Console.WriteLine(names.Count);
        }
    }
}
