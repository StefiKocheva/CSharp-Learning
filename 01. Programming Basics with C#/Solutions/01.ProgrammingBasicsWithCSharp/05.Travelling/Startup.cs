namespace _05.Travelling
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string destination = Console.ReadLine();

            decimal totalMoney = 0;

            while (destination != "End")
            {
                decimal moneyForTrip = decimal.Parse(Console.ReadLine());

                decimal money = decimal.Parse(Console.ReadLine());

                while (totalMoney < moneyForTrip)
                {
                    totalMoney += money;
                    if (totalMoney >= moneyForTrip)
                    {
                        continue;
                    }
                    money = decimal.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to { destination}!");
                totalMoney -= moneyForTrip;

                destination = Console.ReadLine();
            }
        }
    }
}
