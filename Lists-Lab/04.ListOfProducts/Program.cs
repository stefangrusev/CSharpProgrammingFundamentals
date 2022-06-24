using System;
using System.Collections.Generic;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<string> listOfProducts = new List<string>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                string currentProduct = Console.ReadLine();
                listOfProducts.Add(currentProduct);
            }
            listOfProducts.Sort();

            for (int i = 0; i < listOfProducts.Count; i++)
            {
                Console.WriteLine($"{i+1}.{listOfProducts[i]}");
            }
        }
    }
}
