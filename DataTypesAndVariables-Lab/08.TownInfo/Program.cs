using System;

namespace _08.TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            int populationCount = int.Parse(Console.ReadLine());
            int areaNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {populationCount} and area {areaNumber} square km.");
        }
    }
}
