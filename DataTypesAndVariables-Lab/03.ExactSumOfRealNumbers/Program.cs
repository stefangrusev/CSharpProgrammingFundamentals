using System;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            decimal exactSum = 0;

            for (int i = 0; i < count; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                exactSum += num;
            }

            Console.WriteLine(exactSum);
        }
    }
}
