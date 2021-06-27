namespace _07.YardGreening
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int squareMeters = int.Parse(Console.ReadLine());

            decimal price = squareMeters * 7.61m;

            decimal discount = price * 18 / 100;

            price -= discount;

            Console.WriteLine($"The final price is: {Math.Round(price, 2)} lv.");
            Console.WriteLine($"The discount is: {Math.Round(discount, 2)} lv.");
        }
    }
}
