using System;
using System.Linq;

namespace _02.Task_Arrays // "Pascal Triangle" from Arrays - More Exercise / SoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[] primaryArray = new int[rows];
            int[] newArray = new int[rows];
            int[] output = null;

            primaryArray[0] = 1;
            newArray[0] = 1;

            Console.WriteLine(1);

            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < rows; j++)
                {
                    newArray[j] = primaryArray[j] + primaryArray[j - 1];
                }

                primaryArray = newArray.ToArray();
                int[] initialArray = primaryArray;
                output = new int[primaryArray.Length - initialArray.Count(x => x == 0)];

                for (int j = 0; j < output.Length; j++)
                {
                    output[j] = primaryArray[j];
                }

                Console.WriteLine(string.Join(" ", output));
            }
        }
    }
}
