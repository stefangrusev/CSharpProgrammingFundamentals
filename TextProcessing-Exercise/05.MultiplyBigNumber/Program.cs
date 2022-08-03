using System;
using System.Numerics;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            BigInteger result = number * multiplier;
            Console.WriteLine(result);

            ///the shortest solution:
            // Console.WriteLine(BigInteger.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine()));
        }
    }
}
