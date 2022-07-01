using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var listToChange = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commandToManipulateTheList = Console.ReadLine().Split(' ').ToArray();

            commandToManipulateTheList = actionsMethod(listToChange, commandToManipulateTheList);

            Console.WriteLine(String.Join(" ", listToChange));

        }

        private static string[] actionsMethod(List<int> listToChange, string[] commandToManipulateTheList)
        {
            while (commandToManipulateTheList[0] != "end")
            {
                if (commandToManipulateTheList[0] == "Delete")
                {
                    int element = int.Parse(commandToManipulateTheList[1]);
                    listToChange.RemoveAll(n => n == element);
                }
                else if (commandToManipulateTheList[0] == "Insert")
                {
                    int element = int.Parse(commandToManipulateTheList[1]);
                    int index = int.Parse(commandToManipulateTheList[2]);
                    listToChange.Insert(index, element);
                }

                commandToManipulateTheList = Console.ReadLine().Split();

            }

            return commandToManipulateTheList;
        }
    }
}
