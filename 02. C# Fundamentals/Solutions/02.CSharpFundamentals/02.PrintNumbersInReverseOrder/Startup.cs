namespace _02.PrintNumbersInReverseOrder
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                numbers[i] = currentNumber;
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
