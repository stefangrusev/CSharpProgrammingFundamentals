using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split().Select(int.Parse).ToList();
            string consoleCommand = Console.ReadLine();
            while (consoleCommand != "end")
            {
                var wayOfManipulation = consoleCommand.Split();
                if (wayOfManipulation[0] == "Add")
                {
                    inputList.Add(int.Parse(wayOfManipulation[1]));
                }
                else if (wayOfManipulation[0] == "Remove")
                {
                    inputList.Remove(int.Parse(wayOfManipulation[1]));
                }
                else if (wayOfManipulation[0] == "RemoveAt")
                {
                    inputList.RemoveAt(int.Parse(wayOfManipulation[1]));
                }
                else if (wayOfManipulation[0] == "Insert")
                {
                    inputList.Insert(int.Parse(wayOfManipulation[2]), int.Parse(wayOfManipulation[1]));
                }
                consoleCommand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
