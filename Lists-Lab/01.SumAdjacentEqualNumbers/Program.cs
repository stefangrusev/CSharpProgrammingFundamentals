using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inputNumbers = Console.ReadLine()
                    .Split().Select(double.Parse).ToList();
            for (int i = 0; i < inputNumbers.Count - 1; i++)
            {
                if (inputNumbers[i] == inputNumbers[i + 1])
                {
                    inputNumbers[i] += inputNumbers[i + 1];
                    inputNumbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(String.Join(" ", inputNumbers));
        }
    }
}


