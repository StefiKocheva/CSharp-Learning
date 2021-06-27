namespace If_Else
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
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
        }
    }
}
