namespace _07.PascalTriangle
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] triangle = new int[rows][];

            if (rows == 1)
            {
                Console.WriteLine(1);

                return;
            }

            triangle[0] = new int[1] { 1 };
            triangle[1] = new int[2] { 1, 1 };

            for (int row = 2; row < rows; row++)
            {
                triangle[row] = new int[row + 1];
                triangle[row][0] = 1;
                triangle[row][triangle[row].Length - 1] = 1;

                for (int col = 1; col < triangle[row].Length - 1; col++)
                {
                    triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
                }
            }

            foreach (var row in triangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
