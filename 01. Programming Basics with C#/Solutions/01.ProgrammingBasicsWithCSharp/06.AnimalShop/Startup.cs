namespace _06.AnimalShop
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int dogs = int.Parse(Console.ReadLine());
            int others = int.Parse(Console.ReadLine());

            decimal dogsPrice = dogs * 2.5m;
            decimal othersPrice = others * 2.5m;

            decimal total = dogsPrice * othersPrice;

            Console.WriteLine($"{Math.Round(total, 2)} lv.");
        }
    }
}
