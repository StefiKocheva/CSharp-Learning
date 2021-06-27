namespace Enums
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            // First way
            Console.WriteLine(int.Parse(Console.ReadLine()) switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Error",
            });

            //Second way
            Console.WriteLine(int.Parse(Console.ReadLine()) switch
            {
                1 => DaysOfWeek.Monday, // Use the enumeration by its values.
                2 => DaysOfWeek.Tuesday,
                3 => DaysOfWeek.Wednesday,
                4 => DaysOfWeek.Thursday,
                5 => DaysOfWeek.Friday,
                6 => DaysOfWeek.Saturday,
                7 => DaysOfWeek.Sunday,
                _ => "Error",
            });

            //Third way
            Console.WriteLine(Enum.GetName(typeof(DaysOfWeek), int.Parse(Console.ReadLine()))); 
            // Get the name of the enum where the position is equal to the second parameter.
        }
    }
}