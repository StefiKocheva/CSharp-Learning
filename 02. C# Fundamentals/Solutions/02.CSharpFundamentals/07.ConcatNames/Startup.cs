namespace _07.ConcatNames
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();

            string secondName = Console.ReadLine();

            string delimiter = Console.ReadLine();

            Console.WriteLine($"{firstName}{delimiter}{secondName}");
        }
    }
}
