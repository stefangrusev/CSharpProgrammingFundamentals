using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNums = Console.ReadLine()
                 .Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < inputNums.Count / 2; i++)
            {
                result.Add(inputNums[i] + inputNums[inputNums.Count - i - 1]);
            }
            if (inputNums.Count % 2 != 0)
            {
                result.Add(inputNums[inputNums.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
