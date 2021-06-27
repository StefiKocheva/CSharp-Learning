namespace _08.ToyShop
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var tripPrice = double.Parse(Console.ReadLine());
            var puzzlesCount = int.Parse(Console.ReadLine());
            var dollsCount = int.Parse(Console.ReadLine());
            var teddyBearsCount = int.Parse(Console.ReadLine());
            var minionsCount = int.Parse(Console.ReadLine());
            var trucksCount = int.Parse(Console.ReadLine());

            var price = puzzlesCount * 2.60 + dollsCount * 3 + teddyBearsCount * 4.10 + minionsCount * 8.20 + trucksCount * 2;
            var toysCount = puzzlesCount + dollsCount + teddyBearsCount + minionsCount + trucksCount;

            if (toysCount >= 50)
            {
                var discount = 0.25 * price;
                price -= discount;
            }

            var storagePrice = 0.1 * price;
            var wonMoney = price - storagePrice;

            if (wonMoney >= tripPrice)
            {
                Console.WriteLine($"Yes! {(wonMoney - tripPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Round(tripPrice - wonMoney, 2)} lv needed.");
            }
        }
    }
}
