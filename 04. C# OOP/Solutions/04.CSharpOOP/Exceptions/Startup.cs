namespace Exceptions
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                throw new ArgumentException("You can't drink.");
            }
        }
    }
}
