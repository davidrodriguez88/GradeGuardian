using System;
using System.Collections.Generic;

namespace GradeGuardian
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            var student1 = new Student { Name = "Cartman", Id = 1 };
            var student2 = new Student { Name = "Stan", Id = 2 };
            var student3 = new Student { Name = "Kyle", Id = 3 };
            var student4 = new Student { Name = "Kenny", Id = 4 };

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            student1.AddGrade(65);
            student1.AddGrade(44, 32, 40);

            student2.AddGrade(75);
            student2.AddGrade(88, 69, 70);

            student3.AddGrade(90);
            student3.AddGrade(89.9, 94, 97);

            student4.AddGrade(64);
            student4.AddGrade(72.6, 55, 68.3);

            foreach (var student in students)
            {
                Console.WriteLine();
                Console.WriteLine($"Name: {student.Name} \nID: {student.Id}");

                string gradesOutput = string.Join(", ", student.Grades);
                Console.WriteLine($"Grades: {gradesOutput}");

                double average = student.CalculateAverageGrade();
                Console.WriteLine($"Average Grade: {average:F2}");
            }

            Course cSharpCourse = new Course
            {
                CourseName = "C# Fundamentals",
                CourseCode = "CS1101"
            };
            
            cSharpCourse.EnrollStudent(student1);
            cSharpCourse.EnrollStudent(student2);

            Console.WriteLine("\n--- Course Info ---");
            Console.WriteLine($"Course Name: {cSharpCourse.CourseName}");
            Console.WriteLine($"Course Code: {cSharpCourse.CourseCode}");
            Console.WriteLine();
            Console.WriteLine("---Enrolled Students---");
            foreach (var student in cSharpCourse.EnrolledStudents)
            {
                Console.WriteLine($"Name: {student.Name} \nID: {student.Id}");
            }
        }
    }
}