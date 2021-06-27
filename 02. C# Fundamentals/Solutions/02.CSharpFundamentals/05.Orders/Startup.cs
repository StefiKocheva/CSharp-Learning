namespace _05.Orders
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string product = Console.ReadLine();

            int quantity = int.Parse(Console.ReadLine());

            Order(product, quantity);
        }

        private static void Order(string product, int quantity)
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine("{0:f2}", quantity * 1.50);
                    break;
                case "water":
                    Console.WriteLine("{0:f2}", quantity * 1.00);
                    break;
                case "coke":
                    Console.WriteLine("{0:f2}", quantity * 1.40);
                    break;
                case "snacks":
                    Console.WriteLine("{0:f2}", quantity * 2.00);
                    break;
            }
        }
    }
}
