using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int charForTheStart = int.Parse(Console.ReadLine());
            int charForTheEnd = int.Parse(Console.ReadLine());
            for (int i = charForTheStart; i <= charForTheEnd; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
