namespace _06.CalculateRectangleArea
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());

            double height = double.Parse(Console.ReadLine());

            double area = GetCalculatedArea(width, height);

            Console.WriteLine(area);
        }

        private static double GetCalculatedArea(double a, double b) => a * b;
    }
}
