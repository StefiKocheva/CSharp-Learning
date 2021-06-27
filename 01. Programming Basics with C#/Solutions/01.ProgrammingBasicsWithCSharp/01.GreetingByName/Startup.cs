namespace _01.GreetingByName
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");
        }
    }
}
