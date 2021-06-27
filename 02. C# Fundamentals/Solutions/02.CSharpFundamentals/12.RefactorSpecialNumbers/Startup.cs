namespace _12.RefactorSpecialNumbers
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int firstChar = i / 10;

                int lastChar = i % 10;

                int sum = firstChar + lastChar;

                bool isSpecial = false;

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }

                Console.WriteLine("{0} -> {1}", i, isSpecial);
            }

        }
    }
}
