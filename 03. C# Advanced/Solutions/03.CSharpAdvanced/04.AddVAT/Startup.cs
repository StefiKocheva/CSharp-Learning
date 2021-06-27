namespace _04.AddVAT
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            var nums = Console
                .ReadLine()
                .Split(", ")
                .Select(decimal.Parse)
                .ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] += nums[i] * 20 / 100;

                nums[i] = Math.Round(nums[i], 2);
            }

            Console.WriteLine(string.Join(Environment.NewLine, nums));
        }
    }
}
