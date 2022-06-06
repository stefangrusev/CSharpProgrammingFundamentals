using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondArr = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int[] combinedArrays = firstArr.Union(secondArr).ToArray(); 

            int sum = 0;

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

                bool equalFirstSecond = firstArr.SequenceEqual(secondArr);
                if (equalFirstSecond is true)
                {
                    sum += firstArr[i];
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
