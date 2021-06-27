namespace _08.Graduation
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int  year = 0;
            double gradeSum = 0, grade;

            while (year < 12)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    year++;
                    gradeSum += grade;
                }
            }

            Console.WriteLine($"{name} graduated.Average grade: {Math.Round(gradeSum / year, 2)}");
        }
    }
}
