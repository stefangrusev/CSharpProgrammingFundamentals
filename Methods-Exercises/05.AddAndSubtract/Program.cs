using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            Console.WriteLine(SubstractWithTheThirdInt(SumOfTheFirstTwoInts(firstInt, secondInt), thirdInt));
        }
        static int SumOfTheFirstTwoInts(int first, int second) => first + second;
        static int SubstractWithTheThirdInt(int first, int second) => first - second;
    }
}
