namespace ListsOverview
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            // We should use the System.Collections.Generic

            // Declaring
            List<int> numbers = new List<int>() { 1, 2, 3}; // Don't have fixed length

            // Reading values from the console
            List<double> nums = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            // Support foreach loop
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            // Prints its count
            Console.WriteLine(nums.Count);

            // Has positions
            Console.WriteLine(nums[nums.Count - 1]);

            //Support string.Join
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
