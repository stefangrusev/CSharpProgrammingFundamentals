using System;

namespace Arrays_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfTheWeek =
                {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            int currentDay = int.Parse(Console.ReadLine());
            if (currentDay > 0 && currentDay <= 7)
            {
                Console.WriteLine(daysOfTheWeek[currentDay-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
