namespace _03.CountUppercaseWords
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
                .Where(word => char.IsUpper(word[0]))
                .ToList()
                .ForEach(word => Console.WriteLine(word));
        }
    }
}
