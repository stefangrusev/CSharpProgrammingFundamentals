using System;
using System.Linq;

namespace _06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int theLongestSequenceOfEqElements = 1;
            int theSeqStart = 0;
            int currentLength = 1;
            int currentStart = 0;

            for (int i = 1; i < inputArr.Length; i++)
            {
                if (inputArr[i] == inputArr[i - 1])
                {
                    currentLength++;
                    if (currentLength > theLongestSequenceOfEqElements)
                    {
                        theLongestSequenceOfEqElements = currentLength;
                        theSeqStart = currentStart;
                    }
                }
                else
                {
                    currentLength = 1;
                    currentStart = i;
                }
            }

            for (int i = theSeqStart; i < theSeqStart + theLongestSequenceOfEqElements; i++)
            {
                Console.Write(inputArr[i] + " ");
            }
        }
    }
}