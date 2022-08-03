using System;
using System.Collections.Generic;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] users = input.Split(", ");
            List<string> validation = new List<string>();
            foreach (string user in users)
            {
                if (isUsernameValid(user))
                {
                    validation.Add(user);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, validation));
        }

        static bool isUsernameValid(string users)
        {
            switch (users.Length)
            {
                case >= 3 and <= 16:
                    {
                        foreach (char symbol in users)
                        {
                            if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                            {
                                continue;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        return true;
                    }

                default:
                    return false;
            }
        }
    }
}