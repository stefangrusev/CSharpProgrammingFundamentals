using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> points = new Dictionary<string, int>();

            string rawPlayers = Console.ReadLine();
            string[] players = rawPlayers.Split(',', StringSplitOptions.RemoveEmptyEntries);

            foreach (string player in players)
            {
                points[player.Trim()] = 0;
            }

            string command;

            while ((command = Console.ReadLine()) != "end of race")
            {
                StringBuilder currNameSB = new StringBuilder();
                int currentPoints = 0;
                char[] cryptedInfo = command.ToCharArray();
                foreach (char ch in cryptedInfo)
                {
                    if (char.IsLetter(ch))
                    {
                        currNameSB.Append(ch);
                    }
                    else if (char.IsDigit(ch))
                    {
                        currentPoints += int.Parse(ch.ToString());
                    }
                }

                string currName = currNameSB.ToString();
                if (points.ContainsKey(currName))
                {
                    points[currName] += currentPoints;
                }
            }

            points = points.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            if (points.Count > 0)
            {
                Console.WriteLine($"1st place: {points.First().Key.Trim()}");
                points.Remove(points.Keys.First());
            }
            if (points.Count > 0)
            {
                Console.WriteLine($"2nd place: {points.First().Key.Trim()}");
                points.Remove(points.Keys.First());
            }
            if (points.Count > 0)
            {
                Console.WriteLine($"3rd place: {points.First().Key.Trim()}");
                points.Remove(points.Keys.First());
            }
        }
    }
}
