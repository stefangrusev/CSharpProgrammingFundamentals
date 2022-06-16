using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfTheProduct = Console.ReadLine();
            double quantityOfThePurchase = double.Parse(Console.ReadLine());

            TotalPriceOfTheOrder(typeOfTheProduct, quantityOfThePurchase);
        }
        private static void TotalPriceOfTheOrder(string typeOfTheProduct, double quantityOfThePurchase)
        {
            double singleCoffeePrice = 1.50;
            double singleWaterPrice = 1.00;
            double singleCokePrice = 1.40;
            double singleSnacksPrice = 2.00;

            if (typeOfTheProduct == "coffee")
            { Console.WriteLine($"{(quantityOfThePurchase * singleCoffeePrice):f2}"); }
            else if (typeOfTheProduct == "water")
            { Console.WriteLine($"{(quantityOfThePurchase * singleWaterPrice):f2}"); }
            else if (typeOfTheProduct == "coke")
            { Console.WriteLine($"{(quantityOfThePurchase * singleCokePrice):f2}"); }
            else if (typeOfTheProduct == "snacks")
            { Console.WriteLine($"{(quantityOfThePurchase * singleSnacksPrice):f2}"); }
        }
    }
}
