using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deckOne = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> deckTwo = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            while (deckTwo.Count > 0 && deckOne.Count > 0)
            {
                ToCheckMethod(deckOne, deckTwo);
            }

            Console.WriteLine(deckOne.Count > 0 ? $"First player wins! Sum: {deckOne.Sum()}" :
                                                  $"Second player wins! Sum: {deckTwo.Sum()}");
        }

        private static void ToCheckMethod(List<int> deckOne, List<int> deckTwo)
        {
            if (deckOne[0] <= deckTwo[0])
            {
                if (deckTwo[0] > deckOne[0])
                {
                    deckTwo.Add(deckTwo[0]);
                    deckTwo.RemoveAt(0);
                    deckTwo.Add(deckOne[0]);
                    deckOne.Remove(deckOne[0]);
                }
                else if (deckTwo[0] == deckOne[0])
                {
                    deckTwo.Remove(deckTwo[0]);
                    deckOne.Remove(deckOne[0]);
                }
            }

            else
            {
                deckOne.Add(deckOne[0]);
                deckOne.RemoveAt(0);
                deckOne.Add(deckTwo[0]);
                deckTwo.Remove(deckTwo[0]);
            }
        }
    }
}
