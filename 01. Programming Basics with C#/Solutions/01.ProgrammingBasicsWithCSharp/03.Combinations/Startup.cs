namespace _03.Combinations
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int validCombinations = 0;

            for (int i = 0; i <= number; i++)
            {
                for (int j = 0; j <= number; j++)
                {
                    for (int k = 0; k <= number; k++)
                    {
                        if (i + j + k == number)
                        {
                            validCombinations++;
                        }
                    }
                }
            }

            Console.WriteLine(validCombinations);
        }
    }
}
