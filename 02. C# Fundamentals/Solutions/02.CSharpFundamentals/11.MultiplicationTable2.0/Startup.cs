namespace _11.MultiplicationTable2._0
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int multiplier = int.Parse(Console.ReadLine());

            do
            {
                int sum = num * multiplier;

                Console.WriteLine($"{num} X {multiplier} = {sum}");

                multiplier++;
            }
            while (multiplier <= 10);
        }
    }
}
