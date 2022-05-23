using System;

namespace _04.PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int lastInteger = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int allNumbers = firstInteger; allNumbers <= lastInteger; allNumbers++)
            {
                Console.Write($"{allNumbers} ");
                sum += allNumbers;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
