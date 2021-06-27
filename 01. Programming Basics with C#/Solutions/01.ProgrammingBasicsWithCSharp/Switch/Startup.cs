namespace Switch
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var dayOfWeek = int.Parse(Console.ReadLine());

            switch (dayOfWeek)
            {
                case 1: // if (dayOfWeek == 1)
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default: // In all other cases (else).
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
    }
}
