using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int minimalLengthPass = 6;
            const int maximalLengthPass = 10;
            const int counterDigitsPass = 2;

            string inputPass = Console.ReadLine();

            bool isThePassValid = ToValidateThePassMethod(inputPass, minimalLengthPass, maximalLengthPass, counterDigitsPass);
            if (isThePassValid is true) { Console.WriteLine("Password is valid"); }
        }


        static bool ToValidateThePassMethod(string inputPass, int minimalLengthPass, int maximalLengthPass, int counterDigitsPass)
        {
            bool isPasswordValid = true;
            if (!ThePasswordValidation(inputPass, minimalLengthPass, maximalLengthPass))
            {
                Console.WriteLine($"Password must be between {minimalLengthPass} and {maximalLengthPass} characters");
                isPasswordValid = false;
            }
            if (!IsPassAlphaNumerical(inputPass))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isPasswordValid = false;
            }
            if (!IsPassDigitsMinCount(inputPass, counterDigitsPass))
            {
                Console.WriteLine($"Password must have at least {counterDigitsPass} digits");
                isPasswordValid = false;
            }
            return isPasswordValid;
        }


        static bool ThePasswordValidation(string inputPass, int minLength, int maxLength)
        {
            if (inputPass.Length >= minLength && inputPass.Length <= maxLength) { return true; }
            return false;
        }


        static bool IsPassAlphaNumerical(string password)
        {
            foreach (char ch in password) { if (!Char.IsLetterOrDigit(ch)) { return false; } }
            return true;
        }


        static bool IsPassDigitsMinCount(string password, int minDigitsCount)
        {
            int digitsCount = 0;
            foreach (char ch in password) { if (Char.IsDigit(ch)) { digitsCount++; } }
            return digitsCount >= minDigitsCount;
        }
    }
}