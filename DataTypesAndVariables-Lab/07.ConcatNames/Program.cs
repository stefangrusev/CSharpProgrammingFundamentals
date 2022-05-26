using System;

namespace _07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiterType = Console.ReadLine();
            Console.WriteLine($"{firstName}{delimiterType}{secondName}");
        }
    }
}
