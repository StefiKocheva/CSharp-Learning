namespace Action
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            Action<int> cw = x => Console.WriteLine(x); // Action with one parameter

            Action<string, string, int> indroduce = (firstName, lastName, age) =>
            {
                Console.WriteLine($"I am {firstName} {lastName}, a {age}-year-old person.");
            }; // Action with more than one parameter

            cw(4);

            indroduce("Nikolay", "Stoyanov", 15);
        }
    }
}
