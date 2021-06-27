namespace _08.FruitShop
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var fruit = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            switch (dayOfWeek)
            {
                case "Monday":
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine(Math.Round(count * 2.50, 2));
                            break;
                        case "apple":
                            Console.WriteLine(Math.Round(count * 1.20, 2));
                            break;
                        case "orange":
                            Console.WriteLine(Math.Round(count * 0.85, 2));
                            break;
                        case "grapefruit":
                            Console.WriteLine(Math.Round(count * 1.45, 2));
                            break;
                        case "kiwi":
                            Console.WriteLine(Math.Round(count * 2.70, 2));
                            break;
                        case "pineapple":
                            Console.WriteLine(Math.Round(count * 5.50, 2));
                            break;
                        case "grapes":
                            Console.WriteLine(Math.Round(count * 3.85, 2));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Tuesday":
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine(Math.Round(count * 2.50, 2));
                            break;
                        case "apple":
                            Console.WriteLine(Math.Round(count * 1.20, 2));
                            break;
                        case "orange":
                            Console.WriteLine(Math.Round(count * 0.85, 2));
                            break;
                        case "grapefruit":
                            Console.WriteLine(Math.Round(count * 1.45, 2));
                            break;
                        case "kiwi":
                            Console.WriteLine(Math.Round(count * 2.70, 2));
                            break;
                        case "pineapple":
                            Console.WriteLine(Math.Round(count * 5.50, 2));
                            break;
                        case "grapes":
                            Console.WriteLine(Math.Round(count * 3.85, 2));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Wednesday":
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine(Math.Round(count * 2.50, 2));
                            break;
                        case "apple":
                            Console.WriteLine(Math.Round(count * 1.20, 2));
                            break;
                        case "orange":
                            Console.WriteLine(Math.Round(count * 0.85, 2));
                            break;
                        case "grapefruit":
                            Console.WriteLine(Math.Round(count * 1.45, 2));
                            break;
                        case "kiwi":
                            Console.WriteLine(Math.Round(count * 2.70, 2));
                            break;
                        case "pineapple":
                            Console.WriteLine(Math.Round(count * 5.50, 2));
                            break;
                        case "grapes":
                            Console.WriteLine(Math.Round(count * 3.85, 2));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Thursday":
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine(Math.Round(count * 2.50, 2));
                            break;
                        case "apple":
                            Console.WriteLine(Math.Round(count * 1.20, 2));
                            break;
                        case "orange":
                            Console.WriteLine(Math.Round(count * 0.85, 2));
                            break;
                        case "grapefruit":
                            Console.WriteLine(Math.Round(count * 1.45, 2));
                            break;
                        case "kiwi":
                            Console.WriteLine(Math.Round(count * 2.70, 2));
                            break;
                        case "pineapple":
                            Console.WriteLine(Math.Round(count * 5.50, 2));
                            break;
                        case "grapes":
                            Console.WriteLine(Math.Round(count * 3.85, 2));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine(Math.Round(count * 2.50, 2));
                            break;
                        case "apple":
                            Console.WriteLine(Math.Round(count * 1.20, 2));
                            break;
                        case "orange":
                            Console.WriteLine(Math.Round(count * 0.85, 2));
                            break;
                        case "grapefruit":
                            Console.WriteLine(Math.Round(count * 1.45, 2));
                            break;
                        case "kiwi":
                            Console.WriteLine(Math.Round(count * 2.70, 2));
                            break;
                        case "pineapple":
                            Console.WriteLine(Math.Round(count * 5.50, 2));
                            break;
                        case "grapes":
                            Console.WriteLine(Math.Round(count * 3.85, 2));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine(Math.Round(count * 2.70, 2));
                            break;
                        case "apple":
                            Console.WriteLine(Math.Round(count * 1.25, 2));
                            break;
                        case "orange":
                            Console.WriteLine(Math.Round(count * 0.90, 2));
                            break;
                        case "grapefruit":
                            Console.WriteLine(Math.Round(count * 1.60, 2));
                            break;
                        case "kiwi":
                            Console.WriteLine(Math.Round(count * 3.00, 2));
                            break;
                        case "pineapple":
                            Console.WriteLine(Math.Round(count * 5.60, 2));
                            break;
                        case "grapes":
                            Console.WriteLine(Math.Round(count * 4.20, 2));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            Console.WriteLine(Math.Round(count * 2.70, 2));
                            break;
                        case "apple":
                            Console.WriteLine(Math.Round(count * 1.25, 2));
                            break;
                        case "orange":
                            Console.WriteLine(Math.Round(count * 0.90, 2));
                            break;
                        case "grapefruit":
                            Console.WriteLine(Math.Round(count * 1.60, 2));
                            break;
                        case "kiwi":
                            Console.WriteLine(Math.Round(count * 3.00, 2));
                            break;
                        case "pineapple":
                            Console.WriteLine(Math.Round(count * 5.60, 2));
                            break;
                        case "grapes":
                            Console.WriteLine(Math.Round(count * 4.20, 2));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
