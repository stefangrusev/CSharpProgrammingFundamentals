using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfTheCalculation = Console.ReadLine();
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());

            switch (typeOfTheCalculation)
            {
                case "add":
                    AddMethodOfCalculation(firstInteger, secondInteger);
                    break;
                case "multiply":
                    MultiplyMethodOfCalculation(firstInteger, secondInteger);
                    break;
                case "substract":
                    SubstractingMethodOfCalculation(firstInteger, secondInteger);
                    break;
                case "divide":
                        DivideMethodOfCalculation(firstInteger, secondInteger);
                    break;
            }




        }

        private static void DivideMethodOfCalculation(int firstInteger, int secondInteger)
        {
            Console.WriteLine(firstInteger / secondInteger);
        }

        private static void SubstractingMethodOfCalculation(int firstInteger, int secondInteger)
        {
            Console.WriteLine(firstInteger - secondInteger);
        }

        private static void MultiplyMethodOfCalculation(int firstInteger, int secondInteger)
        {
            Console.WriteLine(firstInteger * secondInteger);
        }

        private static void AddMethodOfCalculation(int firstInteger, int secondInteger)
        {
            Console.WriteLine(firstInteger + secondInteger);
        }
    }
}
