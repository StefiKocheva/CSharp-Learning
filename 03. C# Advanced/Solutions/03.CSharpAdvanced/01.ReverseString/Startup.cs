namespace _01.ReverseString
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Stack<char> chars = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                chars.Push(input[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(chars.Pop());
            }
        }
    }
}
