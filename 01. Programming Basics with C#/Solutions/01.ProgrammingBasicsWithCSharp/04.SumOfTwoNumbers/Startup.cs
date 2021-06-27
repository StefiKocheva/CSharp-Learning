namespace _04.SumOfTwoNumbers
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());
            int validCombinationsCount = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    if (i + j == magicalNum)
                    {
                        validCombinationsCount++;
                        Console.WriteLine($"Combination N:{validCombinationsCount} ({i} + {j} = {magicalNum})");
                        return;
                    }
                    else
                    {
                        validCombinationsCount++;
                    }
                }
            }

            Console.WriteLine($"{validCombinationsCount} combinations - neither equals {magicalNum}");
        }
    }
}
