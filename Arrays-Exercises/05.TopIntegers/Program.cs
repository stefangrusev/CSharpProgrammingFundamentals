using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArrIntegers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < inputArrIntegers.Length; i++)
            {
                int runningNumb = inputArrIntegers[i];
                bool itIsBigger = false;

                for (int j = i + 1; j < inputArrIntegers.Length; j++)
                {
                    itIsBigger = false;

                    if (runningNumb > inputArrIntegers[j])
                    {
                        itIsBigger = true;
                    }
                    else { break; }
                }

                if (itIsBigger is true)
                {
                    Console.Write(runningNumb + " ");
                }
            }
            Console.WriteLine(inputArrIntegers[inputArrIntegers.Length - 1]);
        }
    }
}
