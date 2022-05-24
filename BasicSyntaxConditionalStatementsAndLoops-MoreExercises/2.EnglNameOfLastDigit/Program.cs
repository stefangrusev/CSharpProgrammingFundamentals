using System;

namespace _2.EnglNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(LastDigit(number));

        }

        static string LastDigit(string num)
        {
            int lastDigit = num[num.Length - 1];
            string digit = string.Empty;

            digit = lastDigit switch
            {
                '0' => "zero",
                '1' => "one",
                '2' => "two",
                '3' => "three",
                '4' => "four",
                '5' => "five",
                '6' => "six",
                '7' => "seven",
                '8' => "eight",
                '9' => "nine",
                _ => "error",
            };

            return digit;

        }
    }
}
