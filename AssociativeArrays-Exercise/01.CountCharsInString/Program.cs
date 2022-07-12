using System;
using System.Collections.Generic;

namespace _01.CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> characters = new Dictionary<char, int>();

            foreach (char word in text)
            {
                if (word != 32)
                {
                    if (characters.ContainsKey(word))
                    {
                        characters[word]++;
                    }
                    else
                    {
                        characters.Add(word, 1);
                    }
                }
            }

            foreach (KeyValuePair<char, int> character in characters)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
