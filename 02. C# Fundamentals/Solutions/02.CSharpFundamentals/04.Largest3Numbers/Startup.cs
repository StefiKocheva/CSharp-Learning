namespace _04.Largest3Numbers
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

            if (numbers.Length < 3)
            {
                Console.WriteLine(string.Join(" ", numbers));
                return;
            }

            Console.WriteLine(string.Join(" ", numbers.OrderByDescending(num => num).Take(3)));
        }
    }
}
