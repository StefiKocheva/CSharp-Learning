namespace StudentsGradesExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            Dictionary<Student, StudentSubjectGrades> studentsSuccess = new Dictionary<Student, StudentSubjectGrades>();

            Console.WriteLine("Please insert student info in format \n{FirstName} {LastName} {Age} {GradeAtSchool} \nOr type \"Finish\" to finish the seeding of data.");

            string command = Console.ReadLine();

            while (command != "Finish")
            {
                var studentData = command.Split().ToArray();

                var student = new Student()
                {
                    FirstName = studentData[0],
                    LastName = studentData[1],
                    Age = int.Parse(studentData[2]),
                    GradeAtSchool = studentData[3],
                };

                studentsSuccess.Add(student, new StudentSubjectGrades());

                Console.WriteLine(Environment.NewLine + "Please insert the success by subjects of this student in format \n{Subject} {FirstTermGrade} {SecondTermGrade} {YearGrade} \nOr type \"End\" to read another student.");

                var studentSubjectData = Console.ReadLine();

                while (studentSubjectData != "End")
                {
                    var studentSuccessBySubject = studentSubjectData.Split().ToArray();

                    studentsSuccess[student].SubjectSuccess.Add(studentSuccessBySubject[0], new SuccessBySubject()
                    {
                        FirstTerm = double.Parse(studentSuccessBySubject[1]),
                        SecondTerm = double.Parse(studentSuccessBySubject[2]),
                        Year = double.Parse(studentSuccessBySubject[3]),
                    });

                    studentSubjectData = Console.ReadLine();
                }

                Console.WriteLine(Environment.NewLine + "Please insert student info in format \n{FirstName} {LastName} {Age} {GradeAtSchool} \nOr type \"Finish\" to finish the seeding of data.");

                command = Console.ReadLine();
            }

            Console.WriteLine(Environment.NewLine + "Please insert the class you want to receive the list of students in it. \nPer example \"9d\"");

            string @class = Console.ReadLine();

            foreach (var student in studentsSuccess)
            {
                if (student.Key.GradeAtSchool == @class)
                {
                    Console.WriteLine(student.Key.FirstName + " " + student.Key.LastName);
                }
            }

            Console.WriteLine(Environment.NewLine + "Please choose a student from the list above.");

            string studentName = Console.ReadLine();

            while (studentName != "End")
            {
                var studentInfo = studentName.Split().ToArray();

                foreach (var student in studentsSuccess)
                {
                    if (student.Key.FirstName == studentInfo[0] && student.Key.LastName == studentInfo[1])
                    {
                        foreach (var subjectSuccess in student.Value.SubjectSuccess)
                        {
                            Console.WriteLine($"Grades in {subjectSuccess.Key}");
                            Console.WriteLine($"First term: {subjectSuccess.Value.FirstTerm}");
                            Console.WriteLine($"Second term: {subjectSuccess.Value.SecondTerm}");
                            Console.WriteLine($"Year: {subjectSuccess.Value.Year}" + Environment.NewLine);
                        }
                    }
                }

                Console.WriteLine(Environment.NewLine + "Please choose a student from the list above.");

                studentName = Console.ReadLine();
            }
        }
    }
}
