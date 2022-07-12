using System;
using System.Collections.Generic;

namespace _07.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, HashSet<string>>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] companyArgs = command.Split(" -> ");
                string company = companyArgs[0];
                string employee = companyArgs[1];

                if (companies.ContainsKey(company))
                {
                    companies[company].Add(employee);
                }
                else
                {
                    companies.Add(company, new HashSet<string>() { employee });
                }
            }

            foreach (KeyValuePair<string, HashSet<string>> company in companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach (string id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
