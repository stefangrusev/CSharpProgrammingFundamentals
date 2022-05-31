using System;

namespace _01.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());
            int forthInteger = int.Parse(Console.ReadLine());

            int result = (firstInteger + secondInteger) / thirdInteger * forthInteger;
            Console.WriteLine(result);
        }
    }
}
