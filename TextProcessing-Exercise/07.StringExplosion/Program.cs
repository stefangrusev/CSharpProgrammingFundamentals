using System;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            StringBuilder outputText = new StringBuilder();
            int bombPower = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                char currChar = inputString[i];
                bombPower = InsideCheck(inputString, outputText, bombPower, i, currChar);
            }
            Console.WriteLine(outputText.ToString());
        }

        private static int InsideCheck(string inputString, StringBuilder outputText, int bombPower, int i, char currChar)
        {
            switch (currChar)
            {
                case '>':
                    {
                        int currBombPower = GetIntValueOfCharacter(inputString[i + 1]);

                        outputText.Append(currChar);
                        bombPower += currBombPower;
                        break;
                    }

                default:
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        outputText.Append(currChar);
                    }
                    break;
            }

            return bombPower;
        }

        static int GetIntValueOfCharacter(char ch)
        {
            return (int)ch - 48;
        }
    }
}