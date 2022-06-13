using System;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            string[] firstArr = new string[numberOfRows];
            string[] secondArr = new string[numberOfRows];
            for (int index = 0; index < numberOfRows; index++)
            {
                string[] integers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (index % 2 == 0)
                {
                    firstArr[index] = integers[0];
                    secondArr[index] = integers[1];
                }
                else
                {
                    firstArr[index] = integers[1];
                    secondArr[index] = integers[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
