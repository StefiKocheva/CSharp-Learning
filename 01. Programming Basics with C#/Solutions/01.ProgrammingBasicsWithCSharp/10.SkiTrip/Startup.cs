namespace _10.SkiTrip
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var typeOfRoom = Console.ReadLine();
            var grade = Console.ReadLine();
            var nights = days - 1;
            var price = 0d;

            if (days < 10)
            {
                switch (typeOfRoom)
                {
                    case "room for one person":
                        price = nights * 18.00;
                        break;
                    case "apartment":
                        price = nights * 25.00;
                        price -= (price * 0.30);
                        break;
                    case "president apartment":
                        price = nights * 35.00;
                        price -= (price * 0.10);
                        break;
                }
            }
            else if (days <= 15)
            {
                switch (typeOfRoom)
                {
                    case "room for one person":
                        price = nights * 18.00;
                        break;
                    case "apartment":
                        price = nights * 25.00;
                        price -= (price * 0.35);
                        break;
                    case "president apartment":
                        price = nights * 35.00;
                        price -= (price * 0.15);
                        break;
                }
            }
            else
            {
                switch (typeOfRoom)
                {
                    case "room for one person":
                        price = nights * 18.00;
                        break;
                    case "apartment":
                        price = nights * 25.00;
                        price -= (price * 0.50);
                        break;
                    case "president apartment":
                        price = nights * 35.00;
                        price -= (price * 0.20);
                        break;
                }
            }

            switch (grade)
            {
                case "positive":
                    price += (price * 0.25);
                    break;
                case "negative":
                    price -= (price * 0.10);
                    break;
            }

            Console.WriteLine(Math.Round(price, 2));
        }
    }
}
