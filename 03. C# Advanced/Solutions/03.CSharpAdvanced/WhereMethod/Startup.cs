namespace WhereMethod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            int evenSum = 0;
            
            Console
                .ReadLine() // "6 3 1 2 5 4" - string
                .Split() // { "6", "3", "1", "2", "5", "4" } - string[]
                .Select(int.Parse) // { 6, 3, 1, 2, 5, 4 } - int[]
                .Where(num => num % 2 == 0) // { 6, 2, 4 } - int[]
                .OrderBy(num => num) // { 2, 4, 6 } - int[]
                .ToList() // { 2, 4, 6 } - List<int>
                .ForEach(num => evenSum += num); // 1) evenSum += 2; 2) evenSum += 4; 3) evenSum += 6;

            Console.WriteLine($"The sum of even nums in ordered list is: {evenSum}");
        }
    }
}
