namespace RemoveMethod
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            List<string> names = new List<string>() { "Stephie", "Nikolay", "Pesho", "Gosho" }; // Declaring a new list

            names.Remove("Nikolay"); // Remove the element with value "Gosho".
            // There can't be a null position, so the position of every value with larger position than removed one should decrease by 1.
            
            Console.WriteLine(names.Count);
        }
    }
}
