using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal britishPounds = decimal.Parse(Console.ReadLine());
            decimal americanDollars = britishPounds * (decimal)1.31;
            Console.WriteLine($"{americanDollars:f3}");
        }
    }
}
