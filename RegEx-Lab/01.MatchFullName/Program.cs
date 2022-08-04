using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullNamesToMatch = Console.ReadLine();
            string regExPattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex regex = new Regex(regExPattern);
            MatchCollection matches = regex.Matches(fullNamesToMatch);

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
