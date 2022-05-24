using System;
using System.Collections.Generic;

namespace _1.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfnumbers = new List<int>();
            int integerOne = int.Parse(Console.ReadLine());
            listOfnumbers.Add(integerOne);
            int integerTwo = int.Parse(Console.ReadLine());
            listOfnumbers.Add(integerTwo);
            int integerThree = int.Parse(Console.ReadLine());
            listOfnumbers.Add(integerThree);

            listOfnumbers.Sort();
            listOfnumbers.Reverse();
            listOfnumbers.ForEach(Console.WriteLine);
        }
    }
}
