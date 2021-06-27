namespace _03.RoundingNumbers
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            double[] numbers = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number} => {Math.Round(number, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
