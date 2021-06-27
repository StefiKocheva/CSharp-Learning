namespace _04.InchesToCentimeters
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            double inches = double.Parse(Console.ReadLine());

            double centimeters = inches * 2.54;

            Console.WriteLine(centimeters);
        }
    }
}
