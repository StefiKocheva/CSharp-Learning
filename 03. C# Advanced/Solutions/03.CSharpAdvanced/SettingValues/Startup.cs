namespace SettingValues
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] nums = new int[rows, cols]; // Create a new matrix with the parameters above.

            // You should iterate a matrix first by rows, then by cols.

            for (int i = 0; i < rows; i++) // Iterate by rows.
            {
                for (int j = 0; j < cols; j++) // Iterate by cols.
                {
                    // For each row you go through every column there.
                    nums[i, j] = int.Parse(Console.ReadLine()); // Set a value to the cell.
                }
            }
        }
    }
}
