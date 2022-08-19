using System;
using System.Text.RegularExpressions;

namespace _02.MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string regExPattern = @"^([$%])(?<tag>[A-Z][a-z]{2,})(\1): \[(?<firstSymbol>[0-9]+)\]\|\[(?<secondSymbol>[0-9]+)\]\|\[(?<thirdSymbol>[0-9]+)\]\|$";

            for (int i = 0; i < number; i++)
            {
                string stringToValidate = Console.ReadLine();
                Match valid = Regex.Match(stringToValidate, regExPattern);
                if (!valid.Success)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }

                string stringTag = valid.Groups["tag"].Value;
                char firstSymbol = (char)int.Parse(valid.Groups["firstSymbol"].Value);
                char secondSymbol = (char)int.Parse(valid.Groups["secondSymbol"].Value);
                char thirdSymbol = (char)int.Parse(valid.Groups["thirdSymbol"].Value);

                Console.WriteLine($"{stringTag}: {firstSymbol}{secondSymbol}{thirdSymbol}");
            }
        }
    }
}
