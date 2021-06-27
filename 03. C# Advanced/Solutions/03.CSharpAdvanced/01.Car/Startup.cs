namespace _01.Car
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;

            Console.WriteLine($"Make: {car.Make}/nModel: {car.Model}/nYear: {car.Year}");

        }
    }
}
