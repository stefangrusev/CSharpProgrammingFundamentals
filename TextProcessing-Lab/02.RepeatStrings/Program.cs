using System;
using System.Text;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            StringBuilder output = new StringBuilder();

            foreach (string word in words)
            {
                foreach (char character in word)
                {
                    output.Append(word);
                }
            }
            Console.WriteLine(output);
        }
    }
}
