using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenCommand = Console.ReadLine();

            double budget = 0;

            while (givenCommand != "Start")
            {
                double moneySpent = double.Parse(givenCommand);

                if (moneySpent == 0.1 || moneySpent == 0.2 || moneySpent == 0.5 || moneySpent == 1 || moneySpent == 2)
                {
                    budget += moneySpent;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {moneySpent}");
                }

                givenCommand = Console.ReadLine();
            }

            givenCommand = Console.ReadLine();

            while (givenCommand != "End")
            {
                double productPrice = 0;

                switch (givenCommand)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.50;
                        break;
                    case "Soda":
                        productPrice = 0.80;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        givenCommand = Console.ReadLine();
                        continue;
                }

                if (budget < productPrice)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine($"Purchased {givenCommand.ToLower()}");
                    budget -= productPrice;
                }

                givenCommand = Console.ReadLine();
            }
            Console.WriteLine($"Change: {budget:f2}");
        }
    }
}
