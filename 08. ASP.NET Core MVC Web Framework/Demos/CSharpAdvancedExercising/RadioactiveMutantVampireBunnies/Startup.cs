namespace RadioactiveMutantVampireBunnies
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            int[] lairCoordinates = Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rows = lairCoordinates[0];
            int cols = lairCoordinates[1];

            char[,] lairArea = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
            }

            string commands = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine(lairArea[i, j]);
                }
            }
        }
    }
}
