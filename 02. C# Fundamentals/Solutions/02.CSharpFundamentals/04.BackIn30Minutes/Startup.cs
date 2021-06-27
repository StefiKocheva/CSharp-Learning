namespace _04.BackIn30Minutes
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int minutesAfter = minutes + 30;

            if (minutesAfter < 60 )
            {
                Console.WriteLine($"{hours}:{minutesAfter:d2}");
            }
            else
            {
                hours++;

                if (hours == 24)
                {
                    hours = 0;

                    int minutesLow = minutesAfter - 60;

                    Console.WriteLine($"{hours}:{minutesLow:d2}");
                }
                else
                {
                    int minutesLow = minutesAfter - 60;

                    Console.WriteLine($"{hours}:{minutesLow:d2}");
                }
            }
        }
    }
}
