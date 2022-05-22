using System;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfTheWeek = Console.ReadLine();
            int agesOfTheCustomers = int.Parse(Console.ReadLine());

            if (dayOfTheWeek == "Weekday")
            {
                if ((agesOfTheCustomers >= 0 && agesOfTheCustomers <= 18) || (agesOfTheCustomers > 64 && agesOfTheCustomers <= 122))
                {
                    Console.WriteLine("12$");
                }
                else if ((agesOfTheCustomers > 18 && agesOfTheCustomers <= 64))
                {
                    Console.WriteLine("18$");
                }
            }
            if (dayOfTheWeek == "Weekend")
            {
                if ((agesOfTheCustomers >= 0 && agesOfTheCustomers <= 18) || (agesOfTheCustomers > 64 && agesOfTheCustomers <= 122))
                {
                    Console.WriteLine("15$");
                }
                else if ((agesOfTheCustomers > 18 && agesOfTheCustomers <= 64))
                {
                    Console.WriteLine("20$");
                }
            }
            if (dayOfTheWeek == "Holiday")
            {
                if (agesOfTheCustomers >= 0 && agesOfTheCustomers <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (agesOfTheCustomers > 18 && agesOfTheCustomers <= 64)
                {
                    Console.WriteLine("12$");
                }
                else if (agesOfTheCustomers > 64 && agesOfTheCustomers <= 122)
                {
                    Console.WriteLine("10$");
                }

            }
                if (agesOfTheCustomers < 0 || agesOfTheCustomers > 122)
                {
                    Console.WriteLine("Error!");
                }
        }
    }
}
