namespace _05.PrintEvenNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(", ", Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(num => num % 2 == 0)
                .ToArray()));
        }
    }
}
