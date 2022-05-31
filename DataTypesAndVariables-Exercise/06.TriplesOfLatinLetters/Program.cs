using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputInteger = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputInteger; i++)
            {
                for (int j = 0; j < inputInteger; j++)
                {
                    for (int k = 0; k < inputInteger; k++)
                    {
                        char charOne = (char)('a' + i);
                        char charTwo = (char)('a' + j);
                        char charThree = (char)('a' + k);
                        Console.WriteLine($"{charOne}{charTwo}{charThree}");
                    }
                }
            }
        }
    }
}
