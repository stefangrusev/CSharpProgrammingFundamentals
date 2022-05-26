using System;

namespace _09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char inputOne = char.Parse(Console.ReadLine());
            char inputTwo = char.Parse(Console.ReadLine());
            char inputThree = char.Parse(Console.ReadLine());

            Console.WriteLine($"{inputOne}{inputTwo}{inputThree}");
        }
    }
}
