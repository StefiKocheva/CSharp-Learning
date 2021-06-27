namespace _05.StackOfStrings
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var stack = new StackOfStrings();

            Console.WriteLine(stack.IsEmpty());

            stack.Push("hi");

            Console.WriteLine(stack.IsEmpty());

            stack.AddRange(new string[] { "name", "age"});
        }
    }
}
