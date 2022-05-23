using System;

namespace _08.TriangleOfNumbers
{
    class Program
    {
        static void Main()
        {
            int inputInteger = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputInteger; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
