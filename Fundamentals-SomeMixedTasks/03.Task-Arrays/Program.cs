using System;

namespace _03.Task_Arrays // "Recursive Fibonacci" from Arrays - More Exercise / SoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            long[] arr = new long[number];

            if (number == 1 || number == 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                arr[0] = 1;
                arr[1] = 1;
                for (int i = 2; i < arr.Length; i++)
                {
                    arr[i] = arr[i - 1] + arr[i - 2];
                }
            }

            Console.WriteLine(arr[number - 1]);
        }
    }
}
