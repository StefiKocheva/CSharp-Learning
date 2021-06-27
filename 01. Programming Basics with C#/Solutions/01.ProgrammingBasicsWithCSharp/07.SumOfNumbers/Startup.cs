namespace _07.SumOfNumbers
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int sum = 0, count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                sum += currentNum;
            }

            Console.WriteLine(sum);
        }
    }
}
