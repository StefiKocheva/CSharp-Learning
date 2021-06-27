namespace _03.SquareArea
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int area = size * size;

            Console.WriteLine(area);
        }
    }
}
