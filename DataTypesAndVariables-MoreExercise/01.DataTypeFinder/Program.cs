using System;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var possibleDataType = Console.ReadLine();

            while (possibleDataType != "END")
            {
                if (!Int32.TryParse(possibleDataType, out _))
                {
                    if (!float.TryParse(possibleDataType, out _))
                    {
                        if (char.TryParse(possibleDataType, out _))
                        {
                            Console.WriteLine($"{possibleDataType} is character type");
                        }
                        else if (bool.TryParse(possibleDataType, out _))
                        {
                            Console.WriteLine($"{possibleDataType} is boolean type");
                        }
                        else
                        {
                            Console.WriteLine($"{possibleDataType} is string type");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{possibleDataType} is floating point type");
                    }
                }
                else
                {
                    Console.WriteLine($"{possibleDataType} is integer type");
                }

                possibleDataType = Console.ReadLine();
            }
        }
    }
}
