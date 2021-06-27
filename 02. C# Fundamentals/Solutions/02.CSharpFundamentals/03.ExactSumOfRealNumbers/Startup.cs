namespace _03.ExactSumOfRealNumbers
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            decimal sum = 0;

            while (counter < number)
            {
                decimal num1 = decimal.Parse(Console.ReadLine());
                sum += num1;
                counter++;
            }

            Console.WriteLine(sum);
        }
    }
}