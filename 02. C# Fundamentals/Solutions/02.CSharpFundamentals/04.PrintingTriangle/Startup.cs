namespace _04.PrintingTriangle
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintingTriangle(n);
        }

        private static void PrintingLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private static void PrintingTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintingLine(1, i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintingLine(1, i);
            }
        }

    }
}
