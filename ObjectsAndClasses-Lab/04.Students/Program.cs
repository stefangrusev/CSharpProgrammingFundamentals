using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = tokens[0];
                string lastName = tokens[1];
                string city = tokens[3];
                int age = int.Parse(tokens[2]);

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName=lastName,
                    Age=age,
                    City=city
                };
                students.Add(student);
                line = Console.ReadLine();
            }

            string filterForCity = Console.ReadLine();
            var studentNamesToPrint = students.Where(x => x.City == filterForCity).ToList();
            foreach (Student student in studentNamesToPrint)
            {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
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
