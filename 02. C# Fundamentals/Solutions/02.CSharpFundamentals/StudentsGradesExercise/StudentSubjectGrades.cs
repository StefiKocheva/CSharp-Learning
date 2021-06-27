namespace StudentsGradesExercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentSubjectGrades
    {
        public StudentSubjectGrades()
        {
            this.SubjectSuccess = new Dictionary<string, SuccessBySubject>();
        }
        public Dictionary<string, SuccessBySubject> SubjectSuccess { get; set; }
    }
}
