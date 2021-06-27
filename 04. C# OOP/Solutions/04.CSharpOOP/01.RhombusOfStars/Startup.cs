namespace _01.RhombusOfStars
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(PrintUpperRow(n, i));
            }

            for (int i = 1; i <= n - 1; i++)
            {
                Console.WriteLine(PrintLowerRow(n, i));
            }
        }

        private static string PrintLowerRow(int n, int i)
        {
            var row = string.Empty;

            for (int j = i; j >= 1 ; j--)
            {
                row += " ";
            }

            for (int j = n - i; j > 0; j--)
            {
                row += "* ";
            }

            return row;
        }

        private static string PrintUpperRow(int n, int i)
        {
            var row = string.Empty;

            for (int j = 1; j <= n - i; j++)
            {
                row += " ";
            }

            for (int j = 0; j < i; j++)
            {
                row += "* ";
            }

            return row;
        }
    }
}
