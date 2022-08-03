using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> text = Console.ReadLine().ToList();
            for (int i = 0; i < text.Count - 1; i++)
            {
                char character = text[i];
                char nextChar = text[i + 1];
                if (character == nextChar)
                {
                    text.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(String.Join("", text));
        }
    }
}