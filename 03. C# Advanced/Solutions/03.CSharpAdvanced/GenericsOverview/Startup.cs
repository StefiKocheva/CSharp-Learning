namespace GenericsOverview
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            var blanket = new Blanket("Black", 200, 180); // Create new classes.
            var pillow = new Pillow("Red", 60, 40);

            var blankets = new Chest<Blanket>(); // Create instances of the Chest class with different types for T.
            var pillows = new Chest<Pillow>();

            blankets.Add(blanket); // Use generic methods.

            pillows.Add(pillow);

            blankets.Remove(blanket);

            Console.WriteLine(pillows.Count);
        }
    }
}
