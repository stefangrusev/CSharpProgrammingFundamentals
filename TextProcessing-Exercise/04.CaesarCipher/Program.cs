using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] ceasar = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                ceasar[i] = (char)(input[i] + 3);
            }
            Console.WriteLine(ceasar);
        }
    }
}