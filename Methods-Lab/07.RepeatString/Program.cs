using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string theRepeatedParameter = Console.ReadLine();
            int numberOfRepeats = int.Parse(Console.ReadLine());
            Console.WriteLine(TheSequenceOfTheRepeats(theRepeatedParameter, numberOfRepeats));
        }
        static string TheSequenceOfTheRepeats(string theRepeatedParameter, int numberOfRepeats)
        {
            string theRepeats = String.Empty;
            for (int i = 0; i < numberOfRepeats; i++)
            {
                theRepeats+= theRepeatedParameter;
            }
            return theRepeats;
        }
    }
}
