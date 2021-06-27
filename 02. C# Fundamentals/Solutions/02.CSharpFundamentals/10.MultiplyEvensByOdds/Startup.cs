namespace _10.MultiplyEvensByOdds
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int result = Result(number);

            Console.WriteLine(result);

        }

        private static int Result(int num)
        {
            int res = SumOfOddNums(num) * SumOfEvenNums(num);

            return res;
        }

        private static int SumOfOddNums(int num)
        {
            int sum = 0;
            int number = num % 10;

            while (num != 0)
            {
                if (number%2 != 0)
                {
                    sum += number;
                }

                num -= number;
                num /= 10;
                number = num % 10;
            }

            return sum;
        }

        private static int SumOfEvenNums(int num)
        {
            int sum = 0;
            int number = num % 10;

            while (num != 0)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }

                num -= number;
                num /= 10;
                number = num % 10;
            }

            return sum;
        }
    }
}
