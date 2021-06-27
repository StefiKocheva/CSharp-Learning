namespace _09.CharsToString
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());

            char secondChar = char.Parse(Console.ReadLine());

            char thirdChar = char.Parse(Console.ReadLine());

            Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
        }
    }
}
