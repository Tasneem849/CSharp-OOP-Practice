using CSharp_Practice;
using System;
using System.Collections.Generic;

namespace CSharp_Practice
{
    class StudentGrades
    {
        public string StudentName { get; set; }
        public string StudentId { get; set; }
        public List<double> Grades { get; set; } = new List<double>() { 0, 0, 0, 0 };
        public static List<string> Courses { get; private set; } = new List<string>() { "Math", "English", "Science", "Programming" };

        public StudentGrades(string _StudentName, string _StudentId, List<double> _Grades)
        {
            this.StudentName = _StudentName;
            this.StudentId = _StudentId;
            this.Grades = _Grades.Count == Courses.Count ? _Grades : new List<double>() { 0, 0, 0, 0 };
        }

        public double GetAverage()
        {
            double sum = 0.0;

            foreach (double grade in this.Grades)
            {
                sum += grade;
            }

            return sum / this.Grades.Count;
        }

        public void DisplayGrades()
        {
            Console.WriteLine($"The grades of {this.StudentName} [ID: #{this.StudentId}]");
            
            for (int i = 0; i < this.Grades.Count; i++)
                Console.WriteLine($"{Courses[i]} Course :: {this.Grades[i]}");
        }

        public override string ToString()
        {
            return $"ID: #{this.StudentId}  Name: {this.StudentName}";
        }
    }
}


//static void Main(string[] args)
//{
//    List<StudentGrades> students = new() {  new StudentGrades("John Doe 1", "1914510", new List<double>() { 55, 67.4, 13, 50 }),
//                                            new StudentGrades("John Doe 2", "1924511", new List<double>() { 65, 60, 25, 55 }),
//                                            new StudentGrades("John Doe 3", "1934512", new List<double>() { 35, 67.4, 100, 50 }),
//                                            new StudentGrades("John Doe 4", "1944513", new List<double>() { 71.3, 64, 33, 50 }),
//                                            new StudentGrades("John Doe 5", "1954514", new List<double>() { 80.3, 67.4, 13, 50 })
//                                         };

//    foreach (StudentGrades student in students)
//    {
//        student.DisplayGrades();
//        Console.WriteLine($"Average is: {student.GetAverage()}\n");
//    }

//}