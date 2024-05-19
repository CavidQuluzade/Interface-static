namespace TaskStudenGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GradeClass grade = new GradeClass("Math", GradeClass.Degree.A);
            GradeClass grade1 = new GradeClass("C#", GradeClass.Degree.B);
            Student student = new Student("Javid");
            student.AddGrade(grade);
            student.AddGrade(grade1);
            student.GetAllGrades();
        }
    }
}
