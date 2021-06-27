namespace KeyValuePairs
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string[] daysOfWeek = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.WriteLine(daysOfWeek[3]);
            // position -> value
            // 3 -> Thursday
            // "3" is the key of this position
            // key -> value
            // int -> string
        }
    }
}
