using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int metersInput = int.Parse(Console.ReadLine());
            double kilometers = metersInput / 1000d; //'d' for "double" or 1000.0 which is same
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
