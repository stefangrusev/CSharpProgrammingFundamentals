using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfVariable = Console.ReadLine();

            if (typeOfVariable == "int")
            {
                int firstIntToCompare = int.Parse(Console.ReadLine());
                int secondIntToCompare = int.Parse(Console.ReadLine());
                Console.WriteLine(GetTheBiggestOne(firstIntToCompare, secondIntToCompare));
            }
            else if (typeOfVariable == "char")
            {
                char firstCharToCompare = char.Parse(Console.ReadLine());
                char secondCharToCompare = char.Parse(Console.ReadLine());
                Console.WriteLine(GetTheBiggestOne(firstCharToCompare, secondCharToCompare));
            }
            else if (typeOfVariable == "string")
            {
                string firstStringToCompare = Console.ReadLine() ?? throw new ArgumentNullException("Console.ReadLine()");
                string secondStringToCompare = Console.ReadLine();
                Console.WriteLine(GetTheBiggestOne(firstStringToCompare, secondStringToCompare));
            }
        }

        static int GetTheBiggestOne(int firstIntToCompare, int secondIntToCompare)
        {
            if (firstIntToCompare > secondIntToCompare)
            { return firstIntToCompare; }
            return secondIntToCompare;
        }
        static char GetTheBiggestOne(char firstCharToCompare, char secondCharToCompare)
        {
            if (firstCharToCompare > secondCharToCompare)
            { return firstCharToCompare; }
            return secondCharToCompare;
        }
        static string GetTheBiggestOne(string firstStringToCompare, string secondStringToCompare)
        {
            int theBigger = firstStringToCompare.CompareTo(secondStringToCompare);
            if (theBigger > 0)
            { return firstStringToCompare; }
            return secondStringToCompare;
        }
    }
}
