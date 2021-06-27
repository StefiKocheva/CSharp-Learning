namespace Matrix
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            // One dimentional array has just a row like { 'a', 'b', 'c'}.
            // Multidimentional arrays has rows and cols.
            // Every two dimentional array has equal count of elements on each row.
            // Multidimentional arrays are iterating thanks to a nested loops (in common case, two fors).
            // Example:
            // { 'a', 'b', 'c'}
            // { 'd', 'e', 'f'}
            // { 'h', 'i', 'j'}
            // { 'k', 'l', 'm'}

            int[] nums = new int[4] { 1, 2, 3, 4 }; // Row

            //Multidimentional
            int[,] rectangle = new int[4, 3]; // Rows, cols
            int[,,] cube = new int[4, 4, 4];

            Console.WriteLine(nums[1]);

            rectangle[1, 2] = 3;

            Console.WriteLine(rectangle[1, 2]);
        }
    }
}
