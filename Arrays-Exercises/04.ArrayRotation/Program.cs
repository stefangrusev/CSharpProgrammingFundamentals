using System;

namespace _04.ArrayRotation
{
    class Program
    {
        private static int j;

        static void Main(string[] args)
        {
            string[] receivedArray = Console.ReadLine().Split();
            int rotationsToTheLeft = int.Parse(Console.ReadLine());

            string sampleOfTheIntegers = string.Empty;

            for (int i = 0; i < rotationsToTheLeft; i++)
            {
                sampleOfTheIntegers = receivedArray[0];
                for (int j = 0; j < receivedArray.Length - 1; j++)
                {
                    receivedArray[j] = receivedArray[j + 1];
                }

                receivedArray[receivedArray.Length - 1] = sampleOfTheIntegers;
            }

            Console.WriteLine(string.Join(" ", receivedArray));
        }
    }
}
