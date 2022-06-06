using System;

namespace _02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int[] numbers = new int[inputNumber];

            for (int i = 0; i < inputNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
