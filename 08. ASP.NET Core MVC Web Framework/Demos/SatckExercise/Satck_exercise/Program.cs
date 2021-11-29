using System;
using System.Collections.Generic;

namespace Satck_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            string expression = "1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5";

            for (int i = 0; i < expression.Length; i++)
            {
                var @char = expression[i];

                if (@char == '(')
                {
                    stack.Push(i);
                }
                else
                {
                    if (@char == ')')
                    {
                        int startIndex = stack.Pop();


                    }
                }
            }
        }
    }
}
