namespace ConditionalOperators
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            // If-else clause
            int grade = int.Parse(Console.ReadLine());

            if (grade <= 6.00 && grade >= 5.50) // If something...
            {
                Console.WriteLine("Excellent");
            }
            else if (grade >= 4.50) // In other case if...
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 3.50)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 3)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 2)
            {
                Console.WriteLine("Fail");
            }
            else // In all other cases...
            {
                Console.WriteLine("Invalid grade");
            }

            // Switch clause
            // We use switch when we know all the possible values of the variable in the switch.
            // We use only concrete values.
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
