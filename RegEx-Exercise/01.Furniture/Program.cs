using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();

            decimal moneySpent = 0;
            string regExPattern = @"[>]{2}(?<productName>[A-Za-z]+)[<]{2}(?<productPrice>\d+(\.\d+)?)!(?<productQuantity>\d+)";
            string input;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match products = Regex.Match(input, regExPattern);
                if (products.Success)
                {
                    string productName = products.Groups["productName"].Value;
                    decimal productPrice = decimal.Parse(products.Groups["productPrice"].Value);
                    int productQuantity = int.Parse(products.Groups["productQuantity"].Value);

                    furniture.Add(productName);
                    moneySpent += productPrice * productQuantity;
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (string productName in furniture)
            {
                Console.WriteLine(productName);
            }

            Console.WriteLine($"Total money spend: {moneySpent:f2}");
        }

        
    }
}
