namespace PrintingValues
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] nums = new int[rows, cols];

            //Read
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    nums[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Print
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine(nums[i, j]);
                }
            }
        }
    }
}
