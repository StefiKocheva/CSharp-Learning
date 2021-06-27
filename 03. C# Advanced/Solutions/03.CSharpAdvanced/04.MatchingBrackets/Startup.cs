namespace _04.MatchingBrackets
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    int start = indexes.Pop();

                    Console.WriteLine(input.Substring(start, i - start - 1));
                }
            }
        }
    }
}
