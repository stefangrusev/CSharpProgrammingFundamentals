using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(isPalindrome(input));
                input = Console.ReadLine();
            }
        }
        static string isPalindrome(string input)
        {
            string theReversedString = string.Join("", input.Reverse());
            if (input == theReversedString) { return "true"; }
            else { return "false"; }
        }
    }
}

