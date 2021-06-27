namespace _03.PrimaryDiagonal
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int rows = size, cols = size;

            int[,] square = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] rowData = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    square[i, j] = rowData[j];
                }
            }

            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += square[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
