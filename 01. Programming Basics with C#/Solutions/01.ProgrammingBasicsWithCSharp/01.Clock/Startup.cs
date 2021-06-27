namespace _01.Clock
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            for (int i = 0; i <= 23; i++)
            {
                for (int j = 0; j <= 59; j++)
                {
                    Console.WriteLine($"{i}:{j}");
                }
            }
        }
    }
}
