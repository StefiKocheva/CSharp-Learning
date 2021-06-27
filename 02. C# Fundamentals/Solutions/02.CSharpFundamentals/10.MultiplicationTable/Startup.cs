namespace _10.MultiplicationTable
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int sum = i * num;

                Console.WriteLine($"{num} X {i} = {sum}");
            }
        }
    }
}
