using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade()
        {
            return Grades.Average();
        }
    }

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Student s = new Student();

                s.Name = input[0];
                s.Grades = null;
                List<double> grades = new List<double>();

                for (int j = 1; j < input.Length; j++)
                {
                    grades.Add(double.Parse(input[j]));
                }

                s.Grades = grades;
                students.Add(s);
            }


            List<Student> notableStudents = students.OrderBy(student => student.Name).ThenByDescending(student => student.AverageGrade()).ToList();

            foreach (var s in notableStudents)
            {
                if (s.AverageGrade() >= 5)
                {
                    Console.WriteLine("{0:f2} -> {1:f2}", s.Name, s.AverageGrade());
                }
            }
        }
    }
}
