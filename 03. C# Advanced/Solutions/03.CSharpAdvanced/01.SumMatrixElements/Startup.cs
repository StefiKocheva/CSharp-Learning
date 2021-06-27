namespace _01.SumMatrixElements
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            int[] @params = Console
                .ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = @params[0], cols = @params[1];

            int sum = 0;

            int[,] nums = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] rowData = Console
                    .ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    nums[i, j] = rowData[j];

                    sum += nums[i, j];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
