using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();
            string inputCommand;
            while ((inputCommand = Console.ReadLine()) != "end")
            {
                string[] courseArgs = inputCommand.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string course = courseArgs[0];
                string student = courseArgs[1];

                if (!courseInfo.ContainsKey(course))
                {
                    courseInfo[course] = new List<string>();
                }
                courseInfo[course].Add(student);
            }

            CoursesInfo(courseInfo);
        }

        static void CoursesInfo(Dictionary<string, List<string>> courseInfo)
        {
            foreach (var kvp in courseInfo)
            {
                string courseName = kvp.Key;
                List<string> students = kvp.Value;

                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var studentName in students)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
