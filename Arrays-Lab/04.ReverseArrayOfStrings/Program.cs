using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputElements =
                Console.ReadLine()
                .Split(' ')
                .ToArray();
            Array.Reverse(inputElements);
            Console.WriteLine(String.Join(' ', inputElements));

            ////2nd way of solving the task:
            // string[] reversedInput = new string[inputElements.Length];
            //
            // for (int i = 0; i <= inputElements.Length - 1; i++)
            // {
            //     reversedInput[i] = inputElements[inputElements.Length - i - 1];
            // }
            // Console.WriteLine(string.Join(" ", reversedInput));
        }
    }
}
