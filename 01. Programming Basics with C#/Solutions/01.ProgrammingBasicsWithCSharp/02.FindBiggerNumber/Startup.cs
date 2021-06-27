namespace _02.FindBiggerNumber
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                Console.WriteLine(firstNum);
            }
            else
            {
                Console.WriteLine(secondNum);
            }

            // Check on https://docs.microsoft.com/ the ternary operator
            Console.WriteLine(firstNum > secondNum ? firstNum : secondNum);
        }
    }
}
