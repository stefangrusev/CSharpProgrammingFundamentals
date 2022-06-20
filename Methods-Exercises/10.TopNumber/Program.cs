using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int singleInt = int.Parse(Console.ReadLine());
            for (int intsInTheRange = 1; intsInTheRange <= singleInt; intsInTheRange++)
            {
                if (sumDivisibleByEight(intsInTheRange) && NumberContainingOddInt(intsInTheRange))
                {
                    Console.WriteLine(intsInTheRange);
                }
            }
        }
        private static bool sumDivisibleByEight(int intsInTheRange)
        {
            string numbersToCheck = intsInTheRange.ToString();
            double sum = 0;
            foreach (int number in numbersToCheck)
            {
                sum += (int)char.GetNumericValue((char)number);
            }
            if (sum % 8 == 0) { return true; }
            else { return false; }
        }
        private static bool NumberContainingOddInt(int intsInRange)
        {
            string numberToCheck = intsInRange.ToString();
            foreach (int number in numberToCheck)
            {
                if ((int)char.GetNumericValue((char)number) % 2 != 0) { return true; }
            }
            return false;
        }
    }
}
