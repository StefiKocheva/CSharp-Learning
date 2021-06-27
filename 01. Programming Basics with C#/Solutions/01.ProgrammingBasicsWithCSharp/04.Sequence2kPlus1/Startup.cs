namespace _04.Sequence2kPlus1
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var counter = 1;

            while (counter <= number)
            {
                Console.WriteLine(counter);

                counter = (counter * 2) + 1;
            }
        }
    }
}
