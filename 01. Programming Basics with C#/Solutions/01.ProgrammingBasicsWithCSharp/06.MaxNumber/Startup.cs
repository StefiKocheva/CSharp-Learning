namespace _06.MaxNumber
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int count = 1;
            int maxNum = int.MinValue;

            while (count <= number)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }

                count++;
            }

            Console.WriteLine(maxNum);
        }
    }
}
