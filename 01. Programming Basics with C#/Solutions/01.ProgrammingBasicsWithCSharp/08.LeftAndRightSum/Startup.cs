namespace _08.LeftAndRightSum
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int leftSum = 0, rightSum = 0, num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num ; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                leftSum += currentNum;
            }

            for (int i = 0; i < num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                rightSum += currentNum;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
