using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr =
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            foreach (double number in arr)
            {
                int roundedNumber = (int)Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {roundedNumber}");
            }
        }
    }
}
