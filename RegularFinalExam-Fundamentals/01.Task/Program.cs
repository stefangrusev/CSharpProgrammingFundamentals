using System;
using System.Linq;
using System.Text;

namespace _01.Hogwarts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "Abracadabra")
            {
                if (command[0] == "Abjuration")
                {
                    sb.Replace(sb.ToString(), sb.ToString().ToUpper());
                    Console.WriteLine(sb);
                }
                else if (command[0] == "Necromancy")
                {
                    sb.Replace(sb.ToString(), sb.ToString().ToLower());
                    Console.WriteLine(sb);
                }
                else if (command[0] == "Illusion")
                {
                    int index = int.Parse(command[1]);
                    string letter = command[2];
                    int sbLength = sb.ToString().Length - 1;
                    if (index < 0 || index > sbLength)
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                    else
                    {
                        sb.Replace(sb.ToString()[index], char.Parse(letter), index, 1);
                        Console.WriteLine("Done!");
                    }
                }
                else if (command[0] == "Divination")
                {
                    string firstSubstring = command[1];
                    string secondSubstring = command[2];
                    if (sb.ToString().Contains(firstSubstring))
                    {
                        sb.Replace(firstSubstring, secondSubstring);
                        Console.WriteLine(sb);
                    }
                }
                else if (command[0] == "Alteration")
                {
                    string substring = command[1];
                    if (sb.ToString().Contains(substring))
                    {
                        sb.Replace(substring, string.Empty);
                        Console.WriteLine(sb);
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }

                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
