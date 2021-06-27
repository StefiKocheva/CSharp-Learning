namespace Delegates
{
    using System;

    public static class Startup
    {
        public delegate int Sum(int x, int y); // Creates a delegate.

        public static void Main()
        {
            Sum sum = (x, y) => x + y; // Create an instance of the delegate.

            Console.WriteLine(sum(4, 5)); // Uses the instance of the delegate.
        }
    }
}
