using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var products = new Dictionary<string, List<double>>();

            while (input != "buy")
            {
                string[] inputArgs = input.Split(" ").ToArray();
                if (!products.ContainsKey(inputArgs[0]))
                {
                    products.Add(inputArgs[0], new List<double>());
                    products[inputArgs[0]].Add(double.Parse(inputArgs[1]));
                    products[inputArgs[0]].Add(double.Parse(inputArgs[2]));
                }
                else
                {
                    products[inputArgs[0]][0] = double.Parse(inputArgs[1]);
                    products[inputArgs[0]][1] += double.Parse(inputArgs[2]);
                }
                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<double>> item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            }
        }
    }
}
