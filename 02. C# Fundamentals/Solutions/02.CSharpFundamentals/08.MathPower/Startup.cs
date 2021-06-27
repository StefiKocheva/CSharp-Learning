namespace _08.MathPower
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());

            int power = int.Parse(Console.ReadLine());

            double poweredNumber = GetPowerOfNumber(number, power);

            Console.WriteLine(poweredNumber);

        }

        private static double GetPowerOfNumber(double num, int pow)
        {
            double poweredNum = num;

            for (int i = 1; i < pow; i++)
            {
                poweredNum *= num;
            }

            return poweredNum;
        }
    }
}
