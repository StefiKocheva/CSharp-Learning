namespace _04.EvenPowersOf2
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i += 2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
