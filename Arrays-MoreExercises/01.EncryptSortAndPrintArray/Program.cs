using System;

namespace _01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceOfInputStrings = int.Parse(Console.ReadLine());
            int[] receivedArr = new int[sequenceOfInputStrings];

            for (int i = 0; i < sequenceOfInputStrings; i++)
            {
                string receivedStringName = Console.ReadLine();
                int sum = 0;
                for (int j = 0; j < receivedStringName.Length; j++)
                {
                    if (receivedStringName[j] == 97 
                        || receivedStringName[j] == 101 
                        || receivedStringName[j] == 105 
                        || receivedStringName[j] == 111 
                        || receivedStringName[j] == 117 
                        || receivedStringName[j] == 65 
                        || receivedStringName[j] == 69 
                        || receivedStringName[j] == 73 
                        || receivedStringName[j] == 79 
                        || receivedStringName[j] == 85)
                    {
                        sum += receivedStringName[j] * receivedStringName.Length;
                    }
                    else
                    {
                        sum += receivedStringName[j] / receivedStringName.Length;
                    }
                }
                receivedArr[i] = sum;
            }
            Array.Sort(receivedArr);
            for (int i = 0; i < receivedArr.Length; i++)
            {
                Console.WriteLine(receivedArr[i]);
            }
        }
    }
}
