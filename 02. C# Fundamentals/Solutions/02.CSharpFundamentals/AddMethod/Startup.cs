namespace AddMethod
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            List<string> names = new List<string>() { "Stephie", "Nikolay", "Pesho", "Gosho" }; // Declaring a new list

            string newName = "Viktor";

            names.Add(newName); // Adding value at the end of the list

            Console.WriteLine(names.Count); // Printing the names'count
        }
    }
}
