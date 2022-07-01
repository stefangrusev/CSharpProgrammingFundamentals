using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengersInEachWagon = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            string[] addOrFindWagonOrEndCommand = Console.ReadLine().Split(' ').ToArray();

            while (addOrFindWagonOrEndCommand[0] != "end")
            {
                if (addOrFindWagonOrEndCommand[0] == "Add")
                {
                    passengersInEachWagon.Add(int.Parse(addOrFindWagonOrEndCommand[1]));
                }
                else
                {
                    for (int i = 0; i < passengersInEachWagon.Count; i++)
                    {
                        if (wagonCapacity - passengersInEachWagon[i] >= int.Parse(addOrFindWagonOrEndCommand[0]))
                        {
                            passengersInEachWagon[i] += int.Parse(addOrFindWagonOrEndCommand[0]);
                            break;
                        }
                    }
                }
                addOrFindWagonOrEndCommand = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(" ", passengersInEachWagon));
        }

    }
}
