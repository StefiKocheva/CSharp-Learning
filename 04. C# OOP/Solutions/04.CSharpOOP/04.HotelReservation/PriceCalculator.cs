namespace _04.HotelReservation
{
    using System;

    public static class PriceCalculator
    {
        private static decimal pricePerDay;
        private static int days;
        private static Season season;
        private static Discount discount;

        public static decimal GetTotalPrice(string data)
        {
            var reservationData = data.Split();
            PriceCalculator.pricePerDay = decimal.Parse(reservationData[0]);
            PriceCalculator.days = int.Parse(reservationData[1]);
            PriceCalculator.season = (Season)Enum.Parse(typeof(Season), reservationData[2]);
            _ = reservationData.Length == 4
                ? PriceCalculator.discount = (Discount)Enum.Parse(typeof(Discount), reservationData[3])
                : PriceCalculator.discount = Discount.None;
            
            

            var price = PriceCalculator.pricePerDay * PriceCalculator.days;

            var seasonPrice = price * (decimal)PriceCalculator.season;

            var priceDiscount = (decimal)PriceCalculator.discount / 100;

            var total = seasonPrice - seasonPrice * priceDiscount;

            return total;
        }
    }
}
