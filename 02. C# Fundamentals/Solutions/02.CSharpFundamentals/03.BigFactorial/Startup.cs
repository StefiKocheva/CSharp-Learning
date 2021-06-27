namespace _03.BigFactorial
{
    using System;
    using System.Numerics;

    public static class Startup
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
