namespace _01.DayOfWeek
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int day = int.Parse(Console.ReadLine());

            string[] daysOfWeek = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (day > 7 || day < 1)
            {
                Console.WriteLine("Invalid day!");
                return;
            }

            Console.WriteLine(daysOfWeek[day - 1]);
        }
    }
}
