using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string theResult = string.Empty;

            if (dataType == "int")
            {
                int inputAsInt = int.Parse(Console.ReadLine());
                theResult = OverloadedInputOperations(inputAsInt);
            }
            else if (dataType == "real")
            {
                double inputAsDouble = double.Parse(Console.ReadLine());
                theResult = $"{OverloadedInputOperations(inputAsDouble):f2}"; ;
            }
            else if (dataType == "string")
            {
                string inputAsString = Console.ReadLine();
                theResult = OverloadedInputOperations(inputAsString);
            }
            Console.WriteLine(theResult);
        }

        private static string OverloadedInputOperations(string inputAsString)
        {
           return $"${inputAsString}$";
        }

        private static double OverloadedInputOperations(double inputAsDouble)
        {
            double resultForDouble = inputAsDouble * 1.5;
            return resultForDouble;
        }

        private static string OverloadedInputOperations(int inputAsInt)
        {
            return (inputAsInt * 2).ToString();
        }
    }
}
