namespace Stacks
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            Stack<Pillow> chest = new Stack<Pillow>(); // Uses LIFO(Last-in-First-out)

            chest.Push(new Pillow("Red", "Soft", "20x20")); // Insert an element at the bottom at the stack.
            chest.Push(new Pillow("Pink", "Hard", "60x50")); // Insert an element above the previous one.

            var theLazyPillow = chest.Pop(); // Remove the last inserted element.

            var latestPillow = chest.Peek(); // Get the last inserted element.

            Console.WriteLine(chest.Count);

            Console.WriteLine(theLazyPillow.Color);
            Console.WriteLine(latestPillow.Color);
        }
    }
}
