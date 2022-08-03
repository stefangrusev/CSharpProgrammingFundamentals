using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string textToManipulate = Console.ReadLine();

            while (textToManipulate.Contains(wordToRemove))
            {
                textToManipulate = textToManipulate.Remove(textToManipulate.IndexOf(wordToRemove), wordToRemove.Length);
            }

            Console.WriteLine(textToManipulate);
        }
    }
}
