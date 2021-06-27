namespace _04.SymbolInMatrix
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int rows = size, cols = size;

            char[,] characters = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                char[] chars = Console
                    .ReadLine()
                    .ToCharArray();

                for (int j = 0; j < cols; j++)
                {
                    characters[i, j] = chars[j];
                }
            }

            var @char = char.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (characters[i, j] == @char)
                    {
                        Console.WriteLine($"({i}, {j})");

                        return;
                    }
                }
            }

            Console.WriteLine($"{@char} does not occur in the matrix");
        }
    }
}
