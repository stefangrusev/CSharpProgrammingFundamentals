using System;

namespace _01.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double[] numbers = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = double.Parse(input[i]);
            }

            foreach (double number in numbers)
            {
                Console.WriteLine($"{number} => {(int)Math.Round(number, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
