namespace UsingBuildInEnumerators
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var numbers = new Numbers();

            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);

            foreach (var number in numbers) // Enjoy using foreach.
            {
                Console.WriteLine(number);
            }
        }
    }
}
