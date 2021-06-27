namespace _02.AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < count; i++)
            {
                string[] grade = Console.ReadLine().Split();

                if (!grades.ContainsKey(grade[0]))
                {
                    grades.Add(grade[0], new List<double>() { double.Parse(grade[1]) });
                }
                else
                {
                    grades[grade[0]].Add(double.Parse(grade[1]));
                }
            }

            foreach (var (key, value) in grades)
            {
                Console.Write($"{key} -> ");
                foreach (var grade in value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {value.Average():f2})");
            }
        }
    }
}
