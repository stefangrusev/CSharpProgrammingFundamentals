using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PhoneShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var differentPhones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    if (differentPhones.Any(x => x == command[1]))
                    {
                        command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                    differentPhones.Add(command[1]);
                }

                else if (command[0] == "Remove")
                {
                    differentPhones.Remove(command[1]);
                }

                else if (command[0] == "Bonus phone")
                {
                    var bonusPhones = command[1].Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (differentPhones.Any(x => x == bonusPhones[0]))
                    {
                        var indexOfTheOldPhone = differentPhones.FindIndex(x => x == bonusPhones[0]);
                        differentPhones.Insert(indexOfTheOldPhone + 1, bonusPhones[1]);
                    }
                }

                else if (command[0] == "Last")
                {
                    var indexOfPhone = differentPhones.FindIndex(x => x == command[1]);
                    if (indexOfPhone != -1)
                    {
                        string phoneToSave = differentPhones[indexOfPhone];
                        differentPhones.RemoveAt(indexOfPhone);
                        differentPhones.Add(phoneToSave);
                    }
                }

                command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);

            }

            Console.WriteLine(string.Join(", ", differentPhones));

        }
    }
}
