using System;

namespace _04.PrintingTriangle_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsOfThePyramid = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rowsOfThePyramid; i++)
            {
                TheFundamentalOfThePyramid(1, i);
            }
            for (int i = rowsOfThePyramid - 1; i >= 1; i--)
            {
                TheFundamentalOfThePyramid(1, i);
            }
        }
        static void TheFundamentalOfThePyramid(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
