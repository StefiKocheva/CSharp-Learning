namespace JaggedArrays
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            // Standard multidimentional array
            // { 'a', 'b', 'c' }
            // { 'd', 'e', 'f' }
            // { 'h', 'i', 'j' }
            // { 'k', 'l', 'm' }

            // Jagged array
            // { 'a', 'b', 'c', 'd' }
            // { 'e', 'f', 'h' }
            // { 'i', 'j' }
            // { 'k', 'l', 'm' }

            char[][] nums = new char[4][]
            {
                new char[4] { 'a', 'b', 'c', 'd' },
                new char[3] { 'e', 'f', 'h' },
                new char[2] { 'i', 'j' },
                new char[3] { 'k', 'l', 'm' },
            };

            // nums[0] = Console.ReadLine().Split().Select(char.Parse).ToArray(); -> Set a value of type char[] on row 0.

            // Print each number on different line.
            // Print with nested foreach.
            foreach (var arr in nums) // Each line in a jagged array is a single-dimentional array and can be iterated.
            {
                foreach (var @char in arr) // Each line has chars which can be iterated via foreach.
                {
                    Console.WriteLine(@char);
                }
            }

            // Print with white space separator.
            // Use foreach on the outside and for on the inside.
            foreach (var arr in nums)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }

                Console.WriteLine();
            }

            // Print like the input
            // Use foreach
            foreach (var arr in nums)
            {
                Console.WriteLine("{ '" + string.Join("', '", arr) + "' }");
            }
        }
    }
}
