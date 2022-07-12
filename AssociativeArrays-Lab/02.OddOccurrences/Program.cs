using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!counts.ContainsKey(word))
                {
                    counts.Add(word, 1);
                    continue;
                }
                counts[word]++;
            }

            Console.WriteLine(string.Join(" ", counts.Where(x => x.Value % 2 != 0).Select(x => x.Key)));
        }
    }
}
