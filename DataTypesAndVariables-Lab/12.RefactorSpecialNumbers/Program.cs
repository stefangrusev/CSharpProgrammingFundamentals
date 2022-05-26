using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int digitNow = i % 10;
                int digitBefore = (i / 10) % 10;
                Console.WriteLine($"{i} -> {(digitNow + digitBefore == 5) || (digitNow + digitBefore == 7) || (digitNow + digitBefore == 11)}");
            }
        }
    }
}
