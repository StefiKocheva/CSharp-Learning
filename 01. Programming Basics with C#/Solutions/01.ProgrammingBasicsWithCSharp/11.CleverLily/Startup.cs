namespace _11.CleverLily
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var age = int.Parse(Console.ReadLine());
            var washingMachinePrice = decimal.Parse(Console.ReadLine());
            var singleToyPrice = decimal.Parse(Console.ReadLine());

            var toyCount = 0;
            var moneyFromBirthdays = 0m;
            var money = 0m;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyFromBirthdays += 10;
                    money += moneyFromBirthdays - 1;
                }
                else
                {
                    toyCount++;
                }
            }

            decimal moneyFromToys = toyCount * singleToyPrice;

            money += moneyFromToys;

            if (money >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {Math.Round(money - washingMachinePrice, 2)}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Round(washingMachinePrice - money, 2)}");
            }
        }
    }
}
