using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int imputNumber = int.Parse(Console.ReadLine());
            int finalSumOfNumbers = 0;
            while (imputNumber != 0)
            {
                int lastDigit = imputNumber % 10;
                finalSumOfNumbers += lastDigit;
                imputNumber /= 10;
            }
            Console.WriteLine(finalSumOfNumbers);
        }
    }
}
