using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> listToCheckTheNumberOfAllVowels = (Console.ReadLine().ToLower().ToCharArray().ToList());
            int counterVowels = 0;

            for (int i = 0; i < listToCheckTheNumberOfAllVowels.Count; i++)
            {

                if (listToCheckTheNumberOfAllVowels[i] == 'a'
                    || listToCheckTheNumberOfAllVowels[i] == 'e'
                    || listToCheckTheNumberOfAllVowels[i] == 'i'
                    || listToCheckTheNumberOfAllVowels[i] == 'o'
                    || listToCheckTheNumberOfAllVowels[i] == 'u')
                {
                    counterVowels++;
                }
            }
            Console.WriteLine(counterVowels);
        }
    }
}
