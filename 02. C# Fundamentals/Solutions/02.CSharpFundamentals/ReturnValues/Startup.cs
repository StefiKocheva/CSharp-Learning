namespace ReturnValues
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int a = 5;
            int b = 6;

            int sum = Sum(a, b);

            int multiply = Multiply(a, b);
        }

        // Single-line method return the value after the lambda operator.
        private static int Multiply(int a, int b) => a * b;

        //Method that returns a value of type int
        private static int Sum(int a, int b)
        {
            int result = a + b;

            return result; // The keyword is return.
        }


    }
}
