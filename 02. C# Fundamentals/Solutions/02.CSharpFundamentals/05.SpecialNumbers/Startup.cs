namespace _05.SpecialNumbers
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int firstDigit = i / 10;

                int lastDigit = i % 10;

                int sum = firstDigit + lastDigit;

                bool isSpecial = false;

                if(sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");
            }    
        }
    }
}
