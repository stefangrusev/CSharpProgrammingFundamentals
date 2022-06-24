using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integersToReverse = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            integersToReverse.RemoveAll(n => n < 0);
            if (integersToReverse.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                integersToReverse.Reverse();
                Console.WriteLine(string.Join(" ", integersToReverse));
            }
        }
    }
}
