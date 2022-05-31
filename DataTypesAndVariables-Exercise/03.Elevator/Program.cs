using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacityOfTheLevator = int.Parse(Console.ReadLine());
            double peopleCountWithReminder = (double)people / capacityOfTheLevator;
            Console.WriteLine(Math.Ceiling(peopleCountWithReminder));
        }
    }
}
