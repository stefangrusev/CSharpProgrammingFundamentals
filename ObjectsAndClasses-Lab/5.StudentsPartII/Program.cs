using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.StudentsPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>(); //we keeps the students here;
            string givenCommand = Console.ReadLine();

            while (givenCommand != "end")
            {
                string[] studentProperties = givenCommand.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (IsStudentExisting(students, studentProperties[0], studentProperties[1]))
                {
                    Student student = students.FirstOrDefault(x => x.FirstName == studentProperties[0] && x.LastName == studentProperties[1]);

                    student.FirstName = studentProperties[0];
                    student.LastName = studentProperties[1];
                    student.Age = int.Parse(studentProperties[2]);
                    student.City = studentProperties[3];
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = studentProperties[0],
                        LastName = studentProperties[1],
                        Age = int.Parse(studentProperties[2]),
                        City = studentProperties[3]
                    };

                    students.Add(student);
                }

                givenCommand = Console.ReadLine();

            }

            string cityName = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.City==cityName)
                {
                    Console.WriteLine($"{ student.FirstName} { student.LastName} is {student.Age} years old.");
                }
            }
        }

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName) { return true; }
            }
            return false;
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
