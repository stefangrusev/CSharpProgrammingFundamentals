using System;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            while (input % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");

                input = int.Parse(Console.ReadLine());
            }
            if (input % 2 == 0)
            {
                int absInteger = Math.Abs(input);
                Console.WriteLine($"The number is: {absInteger}");
            }
        }
    }
}
