namespace _09.SumOfOddNumbers
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                int number = 2 * i - 1;

                Console.WriteLine(number);

                sum += number;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
