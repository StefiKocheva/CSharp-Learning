namespace _06.Building
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int floorsCount = int.Parse(Console.ReadLine());
            int roomsCount = int.Parse(Console.ReadLine());

            for (int j = 0; j < roomsCount; j++)
            {
                Console.Write($"L{floorsCount}{j}");
                Console.WriteLine();
            }

            for (int i = floorsCount - 1; i > 0; i--)
            {
                for (int j = 0; j < roomsCount; j++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write($"A{i}{j}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write($"O{i}{j}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
