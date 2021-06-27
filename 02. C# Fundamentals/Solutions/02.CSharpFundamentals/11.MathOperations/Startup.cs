namespace _11.MathOperations
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            switch (@operator)
            {
                case "+":
                    Add(num1, num2);
                    break;
                case "-":
                    Subtract(num1, num2);
                    break;
                case "*":
                    Multiply(num1, num2);
                    break;
                case "/":
                    Divide(num1, num2);
                    break;
            }
        }

        private static void Add(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        private static void Subtract(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }

        private static void Multiply(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }

        private static void Divide(int number1, int number2)
        {
            Console.WriteLine(number1 / number2);
        }
    }
}
