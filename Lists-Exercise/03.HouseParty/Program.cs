using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestsAtTheParty = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] keyWords = Console.ReadLine().Split();
                string guestName = keyWords[0];
                checksMethod(guestsAtTheParty, keyWords, guestName);
            }

            Console.WriteLine(String.Join(Environment.NewLine, guestsAtTheParty));
        }
       
        private static void checksMethod(List<string> guestsAtTheParty, string[] keyWords, string guestName)
        {
            switch (keyWords[2])
            {
                case "not":
                    if (guestsAtTheParty.Contains(guestName))
                    {
                        guestsAtTheParty.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                    break;
                default:
                    if (!guestsAtTheParty.Contains(guestName))
                    {
                        guestsAtTheParty.Add(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                    break;
            }
        }
    }
}
