using System;
using System.Linq;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            users = users.OrderByDescending(x => x.Length).ToArray();
            string first = users[0];
            string second = users[1];
            int equalLength = Math.Min(first.Length, second.Length);
            int maxLength = Math.Max(first.Length, second.Length);
            int sum = 0;

            for (int i = 0; i < equalLength; i++)
            {
                sum += NultiplicationAsciiCode(first[i], second[i]);
            }
            for (int j = equalLength; j < maxLength; j++)
            {
                sum += (char)first[j];
            }
            Console.WriteLine(sum);
        }

        static int NultiplicationAsciiCode(char user1, char user2)
        {
            return (char)user1 * (char)user2;
        }
    }
}
