using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskStudenGrade
{
    internal  class Student
    {
        public string Name {  get; set; }
        public GradeClass[] Grade { get; }
        private GradeClass[] grades;
        public Student(string name) 
        {
            Name = name;
            grades = new GradeClass[0];
        }
        public void AddGrade(GradeClass grade)
        {
            Array.Resize(ref grades, grades.Length+1);
            grades[grades.Length-1] = grade;
        }
        public void GetAllGrades()
        {
            foreach(var grade in grades)
            {
                grade.GetDetails();
            }
        }
    }
}
