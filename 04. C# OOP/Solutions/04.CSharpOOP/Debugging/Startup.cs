namespace Debugging
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int a = 5;
            int b = 6;

            int c = a + b;

            Console.WriteLine(c);

            for (int i = 1; i <= 10; i++)
            {
                // Breakpoint with condition:
                Console.WriteLine(c + i);
            }

            // Breakpoint with action (write on the output window):
            Console.WriteLine("Hello");

            // Normal breakpoint:
            Console.WriteLine(123);
        }
    }
}
