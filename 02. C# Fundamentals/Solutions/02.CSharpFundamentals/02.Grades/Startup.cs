namespace _02.Grades
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            GradesCalculation(grade);
        }

        private static void GradesCalculation(double grade)
        {
            if(grade >= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
