using System;

namespace _10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputInteger = int.Parse(Console.ReadLine());
            for (int times = 1; times <= 10; times++)
            {
                int product = inputInteger * times;
                Console.WriteLine($"{inputInteger} X {times} = {product}");
            }
        }
    }
}
