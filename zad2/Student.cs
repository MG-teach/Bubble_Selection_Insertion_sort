using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Student
    {
        public string Name { get; }
        public double Grade { get; }

        public Student(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        public override string ToString() => $"{Name} - {Grade:F2}";
    }
}
