namespace _05.SquareWithMaximumSum
{
    using System;
    using System.Linq;
    using System.Text;

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
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    nums[i, j] = rowData[j];
                }
            }

            int maxSum = int.MinValue;
            int row = 0, col = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    int firstNum = nums[i, j];
                    int secondNum = nums[i, j + 1];
                    int thirdNum = nums[i + 1, j];
                    int forthNum = nums[i + 1, j  + 1];

                    int sum = firstNum + secondNum + thirdNum + forthNum;

                    if (sum > maxSum)
                    {
                        maxSum = sum;

                        row = i;
                        col = j;
                    }
                }
            }

            var sb = new StringBuilder();

            sb.AppendLine($"{nums[row, col]} {nums[row, col + 1]}");
            sb.AppendLine($"{nums[row + 1, col]} {nums[row  + 1, col + 1]}");
            sb.AppendLine(maxSum.ToString());

            Console.WriteLine(sb);
        }
    }
}
