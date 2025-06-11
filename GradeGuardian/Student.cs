
namespace GradeGuardian
{
    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<double> Grades { get; set; } = new List<double>();
        
        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }
        public void AddGrade(params double[] grades)
        {
            Grades.AddRange(grades);
        }
    }
}
