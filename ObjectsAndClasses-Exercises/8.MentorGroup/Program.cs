using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _8.MentorGroup
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Attendance { get; set; }
    }

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ', ',');
            List<Student> students = new List<Student>();

            while (input[0] != "end")
            {
                List<DateTime> attendance = new List<DateTime>();

                Student s = new Student { Name = input[0] };
                int datesCount = input.Length - 1;
                s.Attendance = new List<DateTime>();
                s.Comments = new List<string>();

                for (int i = 1; i <= datesCount; i++)
                {
                    string d = input[i];
                    DateTime date = DateTime.ParseExact(d, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                    attendance.Add(date);
                }

                s.Attendance = attendance;
                students.Add(s);

                input = Console.ReadLine().Split(' ', ',');
            }

            input = Console.ReadLine().Split('-');

            while (input[0] != "end of comments")
            {
                string name = input[0];

                if (students.Any(x => x.Name == name))
                {
                    Student currentStudent = students.First(x => x.Name == name);

                    currentStudent.Comments = new List<string> { input[1] };
                }

                input = Console.ReadLine().Split('-');
            }

            foreach (var student in students.OrderBy(x => x.Name))
            {
                Console.WriteLine(student.Name);

                Console.WriteLine("Comments:");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                foreach (DateTime date in student.Attendance.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {date.Day:d2}/{date.Month:d2}/{date.Year:d4}");
                    //Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
}
