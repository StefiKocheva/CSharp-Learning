namespace _02.PoundsToDollars
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            decimal dollars = pounds * 1.31m;

            Console.WriteLine("{0:f3}", dollars);
        }
    }
}