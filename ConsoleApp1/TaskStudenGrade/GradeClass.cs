using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskStudenGrade
{
    internal class GradeClass
    {
        public enum Degree
        {
            A,
            B,
            C,
            D,
            E
        }
        public Degree degree {  get; set; }
        public string Subject { get; set; }
        public GradeClass(string subject, Degree degree) 
        {
            Subject = subject;
            this.degree = degree;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{Subject} {degree}");
        }
    }
}
