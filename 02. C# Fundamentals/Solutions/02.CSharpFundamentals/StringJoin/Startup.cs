namespace StringJoinAndReversingAnArray
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            int[] numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(string.Join(" + ", numbers) + " = " + numbers.Sum());
            //string.Join(separator, collection).
            //The separator should be a string.
        }
    }
}
