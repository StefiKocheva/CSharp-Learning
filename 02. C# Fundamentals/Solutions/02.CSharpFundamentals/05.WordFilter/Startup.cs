namespace _05.WordFilter
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            Console
                .ReadLine()
                .Split()
                .Where(word => word.Length % 2 == 0)
                .ToList()
                .ForEach(word => Console.WriteLine(word));
        }
    }
}
