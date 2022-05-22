using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputInteger = int.Parse(Console.ReadLine());
            int theFirstMultiplier = int.Parse(Console.ReadLine());

            for (int times = theFirstMultiplier; times <= 10; times++)
            {
                int product = inputInteger * times;
                Console.WriteLine($"{inputInteger} X {times} = {product}");
            }

            if (theFirstMultiplier >= 11)
            {
                Console.WriteLine($"{inputInteger} X {theFirstMultiplier} = {inputInteger * theFirstMultiplier}");
            }
        }
    }
}
