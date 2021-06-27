namespace _03.SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            Stack<string> chars = new Stack<string>(Console
                .ReadLine()
                .Split()
                .Reverse());

            while (chars.Count > 1)
            {
                var firstNum = int.Parse(chars.Pop());
                var @operator = chars.Pop();
                var secondNum = int.Parse(chars.Pop());

                var sum = 0;

                switch (@operator)
                {
                    case "+":
                        sum = firstNum + secondNum;
                        break;
                    case "-":
                        sum = firstNum - secondNum;
                        break;
                }

                chars.Push(sum.ToString());
            }

            Console.WriteLine(chars.Peek());
        }
    }
}
