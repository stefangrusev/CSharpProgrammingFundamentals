using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetForItems = double.Parse(Console.ReadLine());
            int studentsCounter = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double freeBelts = studentsCounter / 6;

            double priceForAllLightsabers = lightsaberPrice * Math.Ceiling(studentsCounter * 1.1);
            double priceForAllRobes = robePrice * studentsCounter;
            double priceForAllBelts = beltPrice * (studentsCounter - freeBelts);

            double calculatedPriceOfAllEquipment = priceForAllLightsabers + priceForAllBelts + priceForAllRobes;

            if (calculatedPriceOfAllEquipment <= budgetForItems)
            {
                Console.WriteLine($"The money is enough - it would cost {calculatedPriceOfAllEquipment:f2}lv.");
            }
            else if (calculatedPriceOfAllEquipment > budgetForItems)
            {
                double neededMoney = calculatedPriceOfAllEquipment - budgetForItems;
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }
        }
    }
}
