using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int sumOfTheOddNumbers = 0;

            for (int i = 1; i <= inputNumber; i++)

            {
                Console.WriteLine(i * 2 - 1);
                sumOfTheOddNumbers += i * 2 - 1;
            }

            Console.WriteLine($"Sum: {sumOfTheOddNumbers}");
        }
    }
}
