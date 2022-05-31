using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerOfTheThing = int.Parse(Console.ReadLine());
            int distanceBetweenTheTargets = int.Parse(Console.ReadLine());
            int exhaustionFactorInteger = int.Parse(Console.ReadLine());
            int currentPower = powerOfTheThing;
            int targetsCount = 0;

            while (currentPower >= distanceBetweenTheTargets)
            {
                currentPower -= distanceBetweenTheTargets;
                targetsCount++;
                if (currentPower == powerOfTheThing * 0.5 && exhaustionFactorInteger != 0)
                {
                    currentPower /= exhaustionFactorInteger;
                }
            }
            Console.WriteLine(currentPower);
            Console.WriteLine(targetsCount);
        }
    }
}
