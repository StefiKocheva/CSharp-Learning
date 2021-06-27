namespace _04.HotelReservation
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var data = Console.ReadLine();

            var totalAmount = PriceCalculator.GetTotalPrice(data);

            Console.WriteLine("{0:f2}", totalAmount);
        }
    }
}
