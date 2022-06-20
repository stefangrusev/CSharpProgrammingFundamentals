using System;
using System.Collections.Generic;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int theFirstIntegerToCompare = int.Parse(Console.ReadLine());
            int theSecondIntegerToCompare = int.Parse(Console.ReadLine());
            int theThirdIntegerToCompare = int.Parse(Console.ReadLine());

            List<int> TheSmallestInteger = new List<int>()
            {
                theFirstIntegerToCompare, 
                theSecondIntegerToCompare, 
                theThirdIntegerToCompare
            };

            TheSmallestInteger.Sort();
            Console.WriteLine(TheSmallestInteger[0]);
        }
    }
}

