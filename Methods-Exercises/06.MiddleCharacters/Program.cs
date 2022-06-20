using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string charsInput = Console.ReadLine();
            MiddleChar(charsInput);
        }
        private static void MiddleChar(string charsInput)
        {
            string middleChar = string.Empty;
            if (charsInput.Length % 2 == 0)
            {
                middleChar = charsInput[charsInput.Length / 2 - 1].ToString();
                middleChar += charsInput[charsInput.Length / 2].ToString();
            }
            else
            {
                middleChar = charsInput[charsInput.Length / 2].ToString();
            }
            Console.WriteLine(middleChar);
        }
    }
}


