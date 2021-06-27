namespace InsertMethod
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            List<string> names = new List<string>() { "Stephie", "Nikolay", "Pesho", "Gosho" }; // Declaring a new list

            names.Insert(1, "Cat"); // Insert the second argument on position given by the first one. 
            // The position of every value with larger position than inserted one should increase by 1.

            Console.WriteLine(string.Join(", ", names));
        }
    }
}
