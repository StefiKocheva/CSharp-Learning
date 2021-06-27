namespace _01.ConvertMetersToKilometers
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int meters = int.Parse(Console.ReadLine());

            double kilometres = meters * 0.001;

            Console.WriteLine("{0:f2}", kilometres);
        }
    }
}
