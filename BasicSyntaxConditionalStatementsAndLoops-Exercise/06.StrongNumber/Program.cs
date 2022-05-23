using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputDigit = int.Parse(Console.ReadLine());
            int theLastNumber = inputDigit;
            int sum = 0;

            while (theLastNumber > 0)
            {
                int digit = theLastNumber % 10;
                int factorial = 1;

                for (int j = 1; j <= digit; j++)
                {
                    factorial *= j;
                }
                sum += factorial;

                theLastNumber /= 10;
            }

            if (sum != inputDigit)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}
