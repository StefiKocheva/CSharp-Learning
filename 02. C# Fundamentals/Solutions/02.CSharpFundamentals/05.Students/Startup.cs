namespace _05.Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] studentInfo = command.Split().ToArray();

                Student student = new Student()
                {
                    FirstName = studentInfo[0],
                    LastName = studentInfo[1],
                    Age = int.Parse(studentInfo[2]),
                    HomeTown = studentInfo[3],
                };

                students.Add(student);
            }

            string town = Console.ReadLine();

            foreach (var student in students)
            {
                if (town == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
