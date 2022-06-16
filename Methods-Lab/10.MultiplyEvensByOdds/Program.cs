using System;
using System.Linq;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int theNumberToManipulate = Math.Abs(int.Parse(Console.ReadLine()));

            int sumOfAllOddNumbers = sumOfAllTheOddNumbers(theNumberToManipulate.ToString());
            int sumOfAllEvenNumbers = SumOfAllTheEvenNumbers(theNumberToManipulate.ToString());

            Console.WriteLine(MultiplyBetweenOddSumAndEvenSum(sumOfAllEvenNumbers, sumOfAllOddNumbers));
        }
        static int MultiplyBetweenOddSumAndEvenSum(int sumOfAllOddNumbers, int sumOfAllEvenNumbers)
        {
            int multiplicatedSums = sumOfAllOddNumbers * sumOfAllEvenNumbers;
            return multiplicatedSums;
        }
        static int SumOfAllTheEvenNumbers(string theNumberToManipulate)
        {
            int sumOfTheEvens = 0;
            for (int i = 0; i < theNumberToManipulate.Length; i++)
            {
                int digit = int.Parse(theNumberToManipulate[i].ToString());
                if (digit % 2 == 0)
                {
                    sumOfTheEvens += digit;
                }
            }
            return sumOfTheEvens;
        }
        static int sumOfAllTheOddNumbers(string theNumberToManipulate)
        {
            int sumOfTheOdds = 0;
            for (int i = 0; i < theNumberToManipulate.Length; i++)
            {
                int digit = int.Parse(theNumberToManipulate[i].ToString());
                if (digit % 2 != 0)
                {
                    sumOfTheOdds += digit;
                }
            }
            return sumOfTheOdds;
        }
    }
}

