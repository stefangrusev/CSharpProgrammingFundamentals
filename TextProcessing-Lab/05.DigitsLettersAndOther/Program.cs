using System;
using System.Linq;

namespace _05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] digits = input.Where(character => char.IsDigit(character)).ToArray();
            char[] letters = input.Where(character => char.IsLetter(character)).ToArray();
            char[] symbols = input.Where(character => !char.IsLetterOrDigit(character)).ToArray();

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
