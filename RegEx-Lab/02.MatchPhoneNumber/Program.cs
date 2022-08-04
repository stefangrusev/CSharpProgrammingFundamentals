using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersToValidate = Console.ReadLine();
            string regExPattern = @"\+359([ \-])2\1[0-9]{3}\1[0-9]{4}\b";

            MatchCollection matches = Regex.Matches(numbersToValidate, regExPattern);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
