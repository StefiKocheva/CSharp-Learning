namespace _02.SumMatrixColumns
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

            int[,] nums = new int[rows, cols];


            for (int i = 0; i < rows; i++)
            {
                int[] rowData = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    nums[i, j] = rowData[j];
                }
            }

            for (int i = 0; i < cols; i++)
            {
                int sum = 0;

                for (int j = 0; j < rows; j++)
                {
                    sum += nums[j, i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
