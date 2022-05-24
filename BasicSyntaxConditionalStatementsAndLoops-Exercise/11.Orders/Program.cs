using System;

namespace _11.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersCounter = int.Parse(Console.ReadLine());

            double pricePerCapsule = 0;
            int days = 0;
            int capsuleCounter = 0;
            double priceOfTheOrder = 0;
            double totalPrice = 0;

            int counter = 1;

            do
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsuleCounter = int.Parse(Console.ReadLine());

                priceOfTheOrder = pricePerCapsule * days * capsuleCounter;
                totalPrice += priceOfTheOrder;
                counter++;

                Console.WriteLine($"The price for the coffee is: ${priceOfTheOrder:f2}");

            } while (counter <= ordersCounter);

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
