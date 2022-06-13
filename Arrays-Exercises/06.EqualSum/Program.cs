using System;
using System.Linq;

namespace _06EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArrNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < inputArrNumbers.Length; i++)
            {
                int sumOfTheLeftOnes = 0;
                int sumOfTheRightOnes = 0;

                for (int j = 0; j < i; j++)
                {
                    sumOfTheLeftOnes += inputArrNumbers[j];
                }
                for (int j = i + 1; j < inputArrNumbers.Length; j++)
                {
                    sumOfTheRightOnes += inputArrNumbers[j];
                }

                if (sumOfTheLeftOnes == sumOfTheRightOnes)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}