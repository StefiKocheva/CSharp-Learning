namespace Queues
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            Queue<Person> lidl = new Queue<Person>(); // Uses FIFO(First-in-First-out)

            lidl.Enqueue(new Person("Stefani", 15, "Bulgarian")); // Insert an element at the begging at the stack.
            lidl.Enqueue(new Person("Nikolay", 15, "Bulgarian")); // Insert an element after the previous one.

            var hasAlreadyBought = lidl.Dequeue(); // Remove the first enqueued element.

            var firstClient = lidl.Peek(); // Get the last enqueued element.

            Console.WriteLine(lidl.Count);

            Console.WriteLine(hasAlreadyBought.Name);
            Console.WriteLine(firstClient.Name);
        }
    }
}
