namespace _08.GraduationPart2
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int failedYears = 0, year = 0;
            double gradeSum = 0, grade;

            while (failedYears < 2 && year < 12)
            {
                grade = int.Parse(Console.ReadLine());
                if (grade < 4.00)
                {
                    failedYears++;

                    if (failedYears == 2)
                    {
                        break;
                    }
                }

                year++;
                gradeSum += grade;
            }

            Console.WriteLine(year == 12
                ? $"{name} graduated.Average grade: {Math.Round(gradeSum / year, 2)}"
                : $"{name} has been excluded at {year} grade");
        }
    }
}
