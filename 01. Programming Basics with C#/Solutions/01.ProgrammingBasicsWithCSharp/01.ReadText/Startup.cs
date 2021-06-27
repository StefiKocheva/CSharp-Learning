namespace _01.ReadText
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            while (text != "Stop")
            {
                text = Console.ReadLine();
            }
        }
    }
}
