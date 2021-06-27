namespace _01.CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            double[] nums = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var occurencies = new Dictionary<double, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!occurencies.ContainsKey(nums[i]))
                {
                    occurencies.Add(nums[i], 1);
                }
                else
                {
                    occurencies[nums[i]]++;
                }
            }

            foreach (var occurency in occurencies)
            {
                Console.WriteLine($"{occurency.Key} -> {occurency.Value} times");
            }
        }
    }
}
