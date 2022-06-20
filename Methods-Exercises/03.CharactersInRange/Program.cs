using System;
using System.Collections.Generic;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstInput = char.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());

            GetMeAllCharacterBetweenTheInputs(firstInput, secondInput);

        }
        static void GetMeAllCharacterBetweenTheInputs(char firstInput, char secondInput)
        {
            if (firstInput >= secondInput)
            {
                char temp;
                temp = secondInput;
                secondInput = firstInput;
                firstInput = temp;
            }

            for (char i = (char)(((int)firstInput)+1); i < secondInput; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
