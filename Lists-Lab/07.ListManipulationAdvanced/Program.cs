using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split().Select(int.Parse).ToList();
            List<int> finalList = inputList.ToList();

            bool manipulations = false;
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
                else if (wayOfManipulation[0] == "Contains")
                {
                    Contains(finalList, int.Parse(wayOfManipulation[1]));
                }
                else if (wayOfManipulation[0] == "PrintEven")
                {
                    EvenInts(finalList);
                }
                else if (wayOfManipulation[0] == "PrintOdd")
                {
                    OddInts(finalList);
                }
                else if (wayOfManipulation[0] == "GetSum")
                {
                    Sum(finalList);
                }
                else if (wayOfManipulation[0] == "Filter")
                {
                    FilterBy(finalList, wayOfManipulation[1], int.Parse(wayOfManipulation[2]));
                }

                consoleCommand = Console.ReadLine();
            }

            if (finalList != inputList && manipulations)
            {
                Console.WriteLine(string.Join(" ", finalList));
            }
        }

        static void Contains(List<int> list, int n)
        {
            Console.WriteLine(list.Contains(n) ? "Yes" : "No such number");
        }


        static void EvenInts(List<int> inputList)
        {
            List<int> result = inputList.ToList();
            result.RemoveAll(x => x % 2 != 0);
            Console.WriteLine(string.Join(" ", result));
        }


        static void OddInts(List<int> inputList)
        {
            List<int> result = inputList.ToList();
            result.RemoveAll(x => x % 2 == 0);
            Console.WriteLine(string.Join(" ", result));
        }


        static void Sum(List<int> inputList)
        {
            Console.WriteLine(inputList.Sum());
        }


        static void FilterBy(List<int> inputList, string sign, int numb)
        {
            switch (sign)
            {
                case "<":
                    Console.WriteLine(string.Join(" ", inputList.Where(x => x < numb)));
                    break;
                case ">":
                    Console.WriteLine(string.Join(" ", inputList.Where(x => x > numb)));
                    break;
                case ">=":
                    Console.WriteLine(string.Join(" ", inputList.Where(x => x >= numb)));
                    break;
                case "<=":
                    Console.WriteLine(string.Join(" ", inputList.Where(x => x <= numb)));
                    break;
            }
        }
    }
}
