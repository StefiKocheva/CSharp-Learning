namespace _09.TradeCommissions
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var town = Console.ReadLine();
            var sails = double.Parse(Console.ReadLine());

            if (sails < 0)
            {
                Console.WriteLine("error");
            }
            else if (sails >= 0 && sails <= 500)
            {
                switch (town)
                {
                    case "Sofia":
                        Console.WriteLine(Math.Round(sails * 5 / 100, 2));
                        break;
                    case "Varna":
                        Console.WriteLine(Math.Round(sails * 4.5 / 100, 2));
                        break;
                    case "Plovdiv":
                        Console.WriteLine(Math.Round(sails * 5.5 / 100, 2));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sails <= 1000)
            {
                switch (town)
                {
                    case "Sofia":
                        Console.WriteLine(Math.Round(sails * 7 / 100, 2));
                        break;
                    case "Varna":
                        Console.WriteLine(Math.Round(sails * 7.5 / 100, 2));
                        break;
                    case "Plovdiv":
                        Console.WriteLine(Math.Round(sails * 8 / 100, 2));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sails <= 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        Console.WriteLine(Math.Round(sails * 8 / 100, 2));
                        break;
                    case "Varna":
                        Console.WriteLine(Math.Round(sails * 10 / 100, 2));
                        break;
                    case "Plovdiv":
                        Console.WriteLine(Math.Round(sails * 12 / 100, 2));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sails > 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        Console.WriteLine(Math.Round(sails * 12 / 100, 2));
                        break;
                    case "Varna":
                        Console.WriteLine(Math.Round(sails * 13 / 100, 2));
                        break;
                    case "Plovdiv":
                        Console.WriteLine(Math.Round(sails * 14.5 / 100, 2));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
