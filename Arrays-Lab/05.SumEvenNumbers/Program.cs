using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfIntegers = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToArray();

            int sum = 0;

            for (int i = 0; i < arrOfIntegers.Length; i++)
            {
                int num = arrOfIntegers[i];
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
