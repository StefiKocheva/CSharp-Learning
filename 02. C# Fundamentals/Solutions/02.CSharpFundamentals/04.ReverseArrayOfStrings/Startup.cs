namespace _04.ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            string[] values = Console.ReadLine().Split().ToArray();
            string[] reversed = new string[values.Length];

            for (int i = 0; i < reversed.Length; i++)
            {
                reversed[i] = values[values.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
