using System;

namespace _01.Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputYears = int.Parse(Console.ReadLine());
            string character = string.Empty;

            if (inputYears >= 0 && inputYears <= 2)
            {
                character = "baby";
            }
            else if (inputYears > 2 && inputYears <= 13)
            {
                character = "child";
            }
            else if (inputYears > 13 && inputYears <= 19)
            {
                character = "teenager";
            }
            else if (inputYears > 19 && inputYears <= 65)
            {
                character = "adult";
            }
            else if (inputYears > 65)
            {
                character = "elder";
            }

            Console.WriteLine($"{character}");

        }
    }
}
