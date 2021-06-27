namespace _06.Students2._0
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

                bool hasChanged = false;

                for (int i = 0; i < students.Count; i++)
                {
                    if (student.FirstName == students[i].FirstName && student.LastName == students[i].LastName)
                    {
                        students[i].Age = student.Age;
                        students[i].HomeTown = student.HomeTown;

                        hasChanged = true;
                    }
                }

                if (!hasChanged)
                {
                    students.Add(student);
                }
                
                command = Console.ReadLine();
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
