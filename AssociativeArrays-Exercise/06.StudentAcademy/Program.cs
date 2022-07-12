using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            int pairOfRows = int.Parse(Console.ReadLine());

            for (int i = 0; i < pairOfRows; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                students[name] = students.ContainsKey(name) ? (students[name] + grade) / 2 : grade;
            }

            foreach (var student in students.Where(student => student.Value >= 4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:F2}");
            }
        }
    }
}
