using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalAmount = 0;
            int days = 0;

            while (startingYield >= 100)
            {
                days++;
                if (days == 1)
                {
                    totalAmount = startingYield - 26;
                }
                else
                {
                    totalAmount += startingYield - 26;
                }
                startingYield -= 10;
            }
            if (totalAmount >= 26)
            {
                totalAmount -= 26;
            }
            else
            {
                totalAmount = 0;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalAmount);

        }
    }
}
