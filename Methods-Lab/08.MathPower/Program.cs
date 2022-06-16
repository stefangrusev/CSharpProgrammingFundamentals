using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            double powerNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(poweredBase(baseNumber, powerNumber));
        }
        static double poweredBase(double baseNumber, double powerNumber)
        {
            double resultOfTheCalculations = Math.Pow(baseNumber, powerNumber);
            return resultOfTheCalculations;
        }
    }
}
