using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var theLengthOfTheSequences = int.Parse(Console.ReadLine());
            var theLongestSeq = -1;
            var theLongestSubIndex = -1;
            var theLongestSubSum = -1;
            var index = 0;
            var sequense = new int[theLengthOfTheSequences];
            var input = Console.ReadLine();
            var indexOfsequence = 1;

            while (input != "Clone them!")
            {
                var currentSequence = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                var SubSequense = 0;
                var SubIndex = 0;
                var SubSum = 0;
                var count = 0;

                for (int i = 0; i < theLengthOfTheSequences; i++)
                {
                    if (currentSequence[i] == 1)
                    {
                        count++;
                        SubSum++;
                        if (count > SubSequense)
                        {
                            SubSequense = count;
                            SubIndex = i - count;
                        }
                    }
                    else { count = 0; }
                   
                }
                if (SubSequense > theLongestSeq)
                {
                    theLongestSeq = SubSequense;
                    theLongestSubIndex = SubIndex;
                    theLongestSubSum = SubSum;
                    sequense = currentSequence;
                    index = indexOfsequence;
                }
                else if (SubSequense == theLongestSeq
                    && theLongestSubIndex > SubIndex)
                {
                    theLongestSubIndex = SubIndex;
                    theLongestSubSum = SubSum;
                    sequense = currentSequence;
                    index = indexOfsequence;
                }
                else if (SubSequense == theLongestSeq
                    && SubIndex == theLongestSubIndex
                    && theLongestSubSum < SubSum)
                {
                    theLongestSubSum = SubSum;
                    sequense = currentSequence;
                    index = indexOfsequence;
                }

                indexOfsequence++;
                input = Console.ReadLine();
            }

            Console.WriteLine("Best DNA sample {0} with sum: {1}."
                , index
                , theLongestSubSum);

            foreach (var item in sequense)
            {
                Console.Write(item + " ");
            }
        }
    }
}