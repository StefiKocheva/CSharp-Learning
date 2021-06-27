namespace SwitchExpression
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            int dayOfWeek = int.Parse(Console.ReadLine());

            Console.WriteLine(DayOfWeek(dayOfWeek));
        }

        private static string DayOfWeek(int dayOfWeek) => dayOfWeek switch // Return the result of the switch.
            {
                1 => "Monday", 
                //case 1:
                //    return "Monday"; 
                //    break;
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Incorrect day", // Default case (discard), always use it in switch expressions.
            };
    }
}
