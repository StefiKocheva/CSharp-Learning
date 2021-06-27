namespace _10.Moving
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var width = int.Parse(Console.ReadLine());
            var length = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var freeSpace = width * length * height;

            var totalBoxesCount = 0;
            var boxes = Console.ReadLine();

            while (boxes != "Done")
            {
                totalBoxesCount += int.Parse(boxes);

                if (totalBoxesCount > freeSpace)
                {
                    Console.WriteLine($"No more free space! You need {totalBoxesCount - freeSpace} Cubic meters more.");
                    return;
                }

                boxes = Console.ReadLine();
            }

            Console.WriteLine($"{freeSpace - totalBoxesCount} Cubic meters left.");
        }
    }
}
