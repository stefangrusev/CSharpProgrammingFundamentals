using System;

namespace _01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            TheTypeOfNumbers();
        }

        static void TheTypeOfNumbers()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber > 0)
            {
                Console.WriteLine($"The number {inputNumber} is positive.");
            }
            else if (inputNumber < 0)
            {
                Console.WriteLine($"The number {inputNumber} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {inputNumber} is zero.");
            }
        }
    }
} 
