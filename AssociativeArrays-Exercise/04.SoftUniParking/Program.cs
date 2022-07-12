using System;
using System.Collections.Generic;

namespace _04.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] register = Console.ReadLine().Split();
                string operation = register[0];
                string user = register[1];
                switch (operation)
                {
                    case "register":
                        string licensePlate = register[2];
                        if (users.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }
                        else
                        {
                            users.Add(user, licensePlate);
                            Console.WriteLine($"{user} registered {licensePlate} successfully");
                        }
                        break;

                    case "unregister":
                        if (!users.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }
                        else
                        {
                            users.Remove(user);
                            Console.WriteLine($"{user} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (KeyValuePair<string, string> user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
