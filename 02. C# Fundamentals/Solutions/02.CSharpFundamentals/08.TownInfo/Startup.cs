namespace _08.TownInfo
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            uint population = uint.Parse(Console.ReadLine());

            double area = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {name} has population of {population} and area {area} square km.");
        }
    }
}
