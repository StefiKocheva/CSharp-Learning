namespace _07.MinNumber
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int count = 1;
            int minNum = int.MaxValue;

            while (count <= number)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < minNum)
                {
                    minNum = currentNum;
                }

                count++;
            }

            Console.WriteLine(minNum);
        }
    }
}
