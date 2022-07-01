using System;

namespace _01.TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAdventure = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double energyOfThePlayers = double.Parse(Console.ReadLine());
            double dailyWaterPerPlayer = double.Parse(Console.ReadLine());
            double dailyFoodPerPlayer = double.Parse(Console.ReadLine());

            double foodForAll = playersCount * dailyFoodPerPlayer * daysOfAdventure;
            double waterForAll = playersCount * dailyWaterPerPlayer * daysOfAdventure;

            for (int i = 1; i <= daysOfAdventure; i++)
            {
                energyOfThePlayers -= double.Parse(Console.ReadLine());
                if (energyOfThePlayers <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {foodForAll:f2} food and {waterForAll:f2} water.");
                    return;
                }
                if (i % 2 == 0)
                {
                    energyOfThePlayers += energyOfThePlayers * 0.05;
                    waterForAll *= 0.70;
                }
                if (i % 3 == 0)
                {
                    foodForAll -= foodForAll / playersCount;
                    energyOfThePlayers += energyOfThePlayers * 0.10;
                }

            }

            Console.WriteLine($"You are ready for the quest. You will be left with - {energyOfThePlayers:f2} energy!");
        }
    }
}
