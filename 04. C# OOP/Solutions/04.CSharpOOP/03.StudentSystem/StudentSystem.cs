namespace _03.StudentSystem
{
    using System;
    using System.Collections.Generic;

    public class StudentSystem
    {
        private Dictionary<string, Student> students;

        public StudentSystem()
        {
            this.students = new Dictionary<string, Student>();
        }

        public void Create(string[] input)
        {
            var name = input[1];
            var age = int.Parse(input[2]);
            var grade = double.Parse(input[3]);

            if (!this.students.ContainsKey(name))
            {
                var student = new Student(name, age, grade);

                this.students[name] = student;
            }
        }

        public void Show(string[] input)
        {
            if (this.students.ContainsKey(input[1]))
            {
                var student = this.students[input[1]];

                var name = student.Name;
                var age = student.Age;
                var grade = this.ToString(student.Grade);

                Console.WriteLine($"{name} is {age} years old. {grade}.");
            }
        }

        public string ToString(double grade)
        {
            if (grade >= 5.00)
            {
                return "Excellent student";
            }
            else if (grade >= 3.50)
            {
                return "Average student";
            }
            else
            {
                return "Very nice person";
            }
        }
    }
}