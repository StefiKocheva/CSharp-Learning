namespace _01.DayOfWeek
{
    using System;
    using System.Globalization;

    public static class Startup
    {
        public static void Main()
        {
            string dateAsText = Console.ReadLine();

            DateTime date = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
