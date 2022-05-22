using System;

namespace _05.MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerN = int.Parse(Console.ReadLine());

            if (integerN == 1)
            {
                Console.WriteLine("January");
            }
            else if (integerN == 2)
            {
                Console.WriteLine("February");
            }
            else if (integerN == 3)
            {
                Console.WriteLine("March");
            }
            else if (integerN == 4)
            {
                Console.WriteLine("April");
            }
            else if (integerN == 5)
            {
                Console.WriteLine("May");
            }
            else if (integerN == 6)
            {
                Console.WriteLine("June");
            }
            else if (integerN == 7)
            {
                Console.WriteLine("Jully");
            }
            else if (integerN == 8)
            {
                Console.WriteLine("August");
            }
            else if (integerN == 9)
            {
                Console.WriteLine("September");
            }
            else if (integerN == 10)
            {
                Console.WriteLine("October");
            }
            else if (integerN == 11)
            {
                Console.WriteLine("November");
            }
            else if (integerN == 12)
            {
                Console.WriteLine("December");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
