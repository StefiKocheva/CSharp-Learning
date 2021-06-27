namespace _02.Password
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var username = Console.ReadLine();
            var password = Console.ReadLine();

            var tryForSignIn = Console.ReadLine();

            while (tryForSignIn != password)
            {
                tryForSignIn = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
