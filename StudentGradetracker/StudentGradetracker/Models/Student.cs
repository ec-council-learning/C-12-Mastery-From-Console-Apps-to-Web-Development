
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradetracker.Models
{
    public class Student
    {
        private static int nextID = 1; // Initialize starting ID
        public int StudentID { get; set; }
        public string Name { get; set; }
        public List<Grade> Grades { get; private set; } = new List<Grade>();

        public Student(string name)
        {
            Name = name;
            StudentID = nextID++; // Assign next ID and increment the counter
        }

        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
        }

        public double CalculateOverallGrade()
        {
            if (Grades.Count == 0)
            {
                return 0.00; // Handle no grades scenario
            }
            return Grades.Average(grade => grade.Score);
        }
        public override string ToString()
        {
            return $"StudentID:{StudentID} \nName:{Name} \nOverall Grade:{CalculateOverallGrade():F2}";
        }
    }
}
