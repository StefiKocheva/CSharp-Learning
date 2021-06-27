namespace _03.SumNumbers
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var command = Console.ReadLine();

            var sum = 0;

            while (command != "Stop")
            {
                var num = int.Parse(command);
                sum += num;

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}
