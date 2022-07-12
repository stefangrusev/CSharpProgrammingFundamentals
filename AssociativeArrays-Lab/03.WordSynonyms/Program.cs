﻿using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            for (int i = 0; i < counter; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();
                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                }
                words[word].Add(synonim);
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
