namespace _03.ProductShop
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            var shops = new SortedDictionary<string, SortedDictionary<string, decimal>>();

            while (command != "Revision")
            {
                string[] input = command.Split(", ");

                if (!shops.ContainsKey(input[0]))
                {
                    shops.Add(input[0], new SortedDictionary<string, decimal>());
                }

                if (!shops[input[0]].ContainsKey(input[1]))
                {
                    shops[input[0]].Add(input[1], decimal.Parse(input[2]));
                }

                command = Console.ReadLine();
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
