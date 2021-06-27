namespace _04.SmallShop
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var product = Console.ReadLine();
            var city = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            switch (city)
            {
                case "Sofia":
                    switch (product)
                    {
                        case "coffee":
                            Console.WriteLine(count * 0.50);
                            break;
                        case "water":
                            Console.WriteLine(count * 0.80);
                            break;
                        case "beer":
                            Console.WriteLine(count * 1.20);
                            break;
                        case "sweets":
                            Console.WriteLine(count * 1.45);
                            break;
                        case "peanuts":
                            Console.WriteLine(count * 1.60);
                            break;
                    }
                    break;
                case "Plovdiv":
                    switch (product)
                    {
                        case "coffee":
                            Console.WriteLine(count * 0.40);
                            break;
                        case "water":
                            Console.WriteLine(count * 0.70);
                            break;
                        case "beer":
                            Console.WriteLine(count * 1.15);
                            break;
                        case "sweets":
                            Console.WriteLine(count * 1.30);
                            break;
                        case "peanuts":
                            Console.WriteLine(count * 1.50);
                            break;
                    }
                    break;
                case "Varna":
                    switch (product)
                    {
                        case "coffee":
                            Console.WriteLine(count * 0.45);
                            break;
                        case "water":
                            Console.WriteLine(count * 0.70);
                            break;
                        case "beer":
                            Console.WriteLine(count * 1.10);
                            break;
                        case "sweets":
                            Console.WriteLine(count * 1.35);
                            break;
                        case "peanuts":
                            Console.WriteLine(count * 1.55);
                            break;
                    }
                    break;
            }
        }
    }
}
