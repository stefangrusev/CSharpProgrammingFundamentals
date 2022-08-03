using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                char[] words = input.ToCharArray();
                Array.Reverse(words);
                string reversed = new string(words);
                Console.WriteLine($"{input} = {reversed}");

                input = Console.ReadLine();
            }
        }
    }
}
