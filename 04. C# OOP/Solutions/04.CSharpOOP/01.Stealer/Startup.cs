namespace _01.Stealer
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            Spy spy = new Spy();

            string result = spy.StealFieldInfo("Hacker", "username", "password");

            Console.WriteLine(result);
        }
    }
}
