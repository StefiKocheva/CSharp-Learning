namespace _02.SumNumbers
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            Func<int[], int> sum = nums => nums.Sum();

            Func<int[], int> count = nums => nums.Length;

            int[] nums = Console
                .ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(count(nums));
            Console.WriteLine(sum(nums));
        }
    }
}
