using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbersCounter = new SortedDictionary<double, int>();
            double[] allCharacters = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (double number in allCharacters)
            {
                if (!numbersCounter.ContainsKey(number))
                {
                    numbersCounter.Add(number, 0);
                }
                numbersCounter[number]++;
            }

            foreach (KeyValuePair<double, int> number in numbersCounter)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
