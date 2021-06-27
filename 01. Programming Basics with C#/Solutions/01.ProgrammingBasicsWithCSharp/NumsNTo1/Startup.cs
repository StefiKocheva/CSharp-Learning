namespace NumsNTo1
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
