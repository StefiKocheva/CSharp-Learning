namespace _05.NumberInRange
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            if (number <= 100 && number >= -100 && number != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
