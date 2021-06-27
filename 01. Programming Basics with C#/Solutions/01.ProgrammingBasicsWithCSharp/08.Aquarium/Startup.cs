namespace _08.Aquarium
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            double length = double.Parse(Console.ReadLine()) / 10;
            double width = double.Parse(Console.ReadLine()) / 10;
            double height = double.Parse(Console.ReadLine()) / 10;
            int percent = int.Parse(Console.ReadLine());

            double volume = length * width * height;

            double usedSpace = volume * percent / 100;

            double freeSpace = volume - usedSpace;

            Console.WriteLine(Math.Round(freeSpace, 3));
        }
    }
}
