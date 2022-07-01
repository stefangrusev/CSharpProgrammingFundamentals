using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bombers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] bombParameters = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int bombNumber = bombParameters[0];
            int thePow = bombParameters[1];

            for (int i = 0; i < bombers.Count; i++)
            {
                if (bombers[i] == bombNumber)
                {
                    if (thePow <= 0)
                    {
                        bombers.RemoveAll(x => x == bombNumber);
                        continue;
                    }

                    if (i - thePow < 0)
                    {
                        for (int j = 0; j <= i + thePow; j++)
                        {
                            bombers.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int j = i - thePow; j <= i + thePow; j++)
                        {
                            if (i - thePow >= bombers.Count)
                            {
                                break;
                            }

                            bombers.RemoveAt(i - thePow);
                        }
                    }
                }
            }
            int sum = bombers.Sum();
            Console.WriteLine(sum);
        }
    }
}
