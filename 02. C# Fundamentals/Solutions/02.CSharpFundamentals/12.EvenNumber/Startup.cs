namespace _12.EvenNumber
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            while (num % 2 != 0)
            {
                num = int.Parse(Console.ReadLine());

                int absolute = Math.Abs(num);

                if (absolute % 2 == 0)
                {
                    Console.WriteLine($"The number is: {absolute}");

                    return;
                }
            }

            int absoluteValue = Math.Abs(num);

            if (absoluteValue % 2 == 0)
            {
                Console.WriteLine($"The number is: {absoluteValue}");
            }
        }
    }
}
