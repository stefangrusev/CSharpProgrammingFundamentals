using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] peoplePerWagon = new int[numberOfWagons];
            int everybodyInTheTrain = 0;

            for (int i = 0; i < numberOfWagons; i++)
            {
                peoplePerWagon[i] = int.Parse(Console.ReadLine());
                everybodyInTheTrain += peoplePerWagon[i];
            }

            Console.WriteLine(string.Join(" ", peoplePerWagon));
            Console.WriteLine(everybodyInTheTrain);
        }
    }
}
