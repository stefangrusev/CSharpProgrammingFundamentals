using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeOfTheStudent();
        }

        private static void GradeOfTheStudent()
        {
            double gradeReceived = double.Parse(Console.ReadLine());
            string outputGrade   = string.Empty;

            if      (gradeReceived < 3)     { outputGrade = "Fail"; }
            else if (gradeReceived < 3.50)  { outputGrade = "Poor"; }
            else if (gradeReceived < 4.50)  { outputGrade = "Good"; }
            else if (gradeReceived < 5.50)  { outputGrade = "Very good"; }
            else if (gradeReceived < 6.01)  { outputGrade = "Excellent"; }

            Console.WriteLine(outputGrade);
        }
    }
}
