using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int theNumberOfLines = int.Parse(Console.ReadLine());
            int waterTank = 255;
            int waterLitres = 0;

            for (int i = theNumberOfLines; i >= 1; i--)
            {
                int litres = int.Parse(Console.ReadLine());
                waterLitres += litres;
                if (waterLitres <= waterTank)
                {
                    continue;
                }
                Console.WriteLine("Insufficient capacity!");
                waterLitres -= litres;
            }
            Console.WriteLine(waterLitres);
        }
    }
}
