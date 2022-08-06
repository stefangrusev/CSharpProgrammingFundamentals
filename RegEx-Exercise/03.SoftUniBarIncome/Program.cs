using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal income = 0m;
            string regExPattern = @"\%(?<client>[A-Z]{1}[a-z]+)\%[^%$|.]*?\<(?<product>\w+)\>[^%$|.]*?\|(?<count>\d+)\|[^%$|.]*?(?<price>\d+(\.\d+)?)*\$";

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match orderInfo = Regex.Match(input, regExPattern);
                income = Total(income, orderInfo);
            }

            Console.WriteLine($"Total income: {income:f2}");
        }

        private static decimal Total(decimal totalIncome, Match orderInfo)
        {
            if (orderInfo.Success)
            {
                int count = int.Parse(orderInfo.Groups["count"].Value);
                decimal price = decimal.Parse(orderInfo.Groups["price"].Value);

                totalIncome += count * price;

                string product = orderInfo.Groups["product"].Value;
                Console.WriteLine($"{orderInfo.Groups["client"].Value}: {product} - {count * price:f2}");
            }

            return totalIncome;
        }
    }
}
