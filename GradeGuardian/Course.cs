using System.Collections.Generic;

namespace GradeGuardian
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }

        private List<Student> enrolledStudents;
        public List<Student> EnrolledStudents => enrolledStudents;

        public Course()
        {
            enrolledStudents = new List<Student>();
        }

        public void EnrollStudent(Student student)
        {
            if (!enrolledStudents.Contains(student))
            {
                enrolledStudents.Add(student);
            }
        }
    }
}