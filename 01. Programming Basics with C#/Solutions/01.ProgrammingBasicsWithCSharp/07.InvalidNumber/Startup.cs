namespace _07.InvalidNumber
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            if (!(number >= 100 && number <= 200 || number == 0))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
