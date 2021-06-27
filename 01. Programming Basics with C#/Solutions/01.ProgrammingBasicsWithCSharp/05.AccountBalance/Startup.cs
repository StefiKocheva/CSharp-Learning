namespace _05.AccountBalance
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            var balance = 0m;

            for (int i = 0; i < count; i++)
            {
                var currentBalance = decimal.Parse(Console.ReadLine());

                if (currentBalance < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    return;
                }

                balance += currentBalance;

                Console.WriteLine($"Increase: {currentBalance:f2}");
            }

            Console.WriteLine($"Total: {Math.Round(balance, 2)}");
        }
    }
}
