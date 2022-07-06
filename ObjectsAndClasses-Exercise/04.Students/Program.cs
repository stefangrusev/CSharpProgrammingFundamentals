using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            GradeSorting(counter, students);

            students = students.OrderByDescending(x => x.Grade).ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }


        private static void GradeSorting(int counter, List<Student> students)
        {
            for (int i = 0; i < counter; i++)
            {
                string[] info = Console.ReadLine().Split(" ").ToArray();
                Student newStudent = new Student
                {
                    FirstName = info[0],
                    SecondName = info[1],
                    Grade = double.Parse(info[2])
                };

                students.Add(newStudent);
            }
        }


        class Student
        {
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {SecondName}: {Grade:F2}";
            }

        }
    }
}