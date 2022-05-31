using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                char digitInput = char.Parse(Console.ReadLine());
                sumOfDigits += (int)digitInput;
            }
                Console.WriteLine($"The sum equals: {sumOfDigits}");
        }
    }
}
