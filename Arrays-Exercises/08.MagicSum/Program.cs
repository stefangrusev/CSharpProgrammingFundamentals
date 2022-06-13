using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                for (int j = i + 1; j < arrayOfIntegers.Length; j++)
                {
                    if (arrayOfIntegers[i] + arrayOfIntegers[j] == sum)
                    {
                        Console.WriteLine($"{arrayOfIntegers[i]} {arrayOfIntegers[j]}");
                    }
                }
            }
        }
    }
}