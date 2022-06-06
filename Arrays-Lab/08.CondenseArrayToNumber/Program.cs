using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfInts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (arrOfInts.Length > 1)
            {
                int[] condensed = new int[arrOfInts.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = arrOfInts[i] + arrOfInts[i + 1];
                }

                arrOfInts = condensed;
            }

            Console.WriteLine(arrOfInts[0]);
        }
    }
}
