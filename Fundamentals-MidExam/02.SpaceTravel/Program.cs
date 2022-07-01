using System;
using System.Linq;

namespace _02.SpaceTravel
{
    class Program
    {
        static void Main(string[] args)
        {
            var travelRouteToTitan = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries).ToList();
            double amountOfFuel = double.Parse(Console.ReadLine());
            double ammunitions = double.Parse(Console.ReadLine());

            for (int i = 0; i < travelRouteToTitan.Count; i++)
            {
                var command = travelRouteToTitan[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                var commandName = command[0];

                switch (commandName)
                {
                    case "Travel":

                        var commandValue = double.Parse(command[1]);

                        if (amountOfFuel >= commandValue)
                        {
                            Console.WriteLine($"The spaceship travelled {commandValue} light-years.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }

                        amountOfFuel-=commandValue;
                        break;

                    case "Enemy":

                        commandValue = double.Parse(command[1]);

                        if (ammunitions >= commandValue)
                        {
                            ammunitions -= commandValue;
                            Console.WriteLine($"An enemy with {commandValue} armour is defeated.");
                        }

                        else
                        {
                            if (amountOfFuel >= commandValue * 2)
                            {
                                amountOfFuel -= commandValue * 2;
                                Console.WriteLine($"An enemy with {commandValue} armour is outmaneuvered.");
                            }

                            else
                            {
                                Console.WriteLine("Mission failed.");
                                return;
                            }
                        }

                        break;

                    case "Repair":

                        commandValue = double.Parse(command[1]);
                        amountOfFuel += commandValue;
                        ammunitions += commandValue * 2;

                        Console.WriteLine($"Ammunitions added: {commandValue * 2}.");
                        Console.WriteLine($"Fuel added: {commandValue}.");

                        break;

                    case "Titan":

                        Console.WriteLine("You have reached Titan, all passengers are safe.");

                        break;
                }
            }
        }
    }
}
