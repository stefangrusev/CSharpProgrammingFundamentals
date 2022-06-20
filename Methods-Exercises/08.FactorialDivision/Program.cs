using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorialN1 = int.Parse(Console.ReadLine());
            int factorialN2 = int.Parse(Console.ReadLine());

            double firstFactorial = Factorial(factorialN1);
            double secondFactorial = Factorial(factorialN2);
            double divideFirstBySecond = firstFactorial / secondFactorial;

            Console.WriteLine($"{divideFirstBySecond:F2}");
        }

        public static double Factorial(double FactorialNumber)
        {
            if (FactorialNumber == 1) { return 1; }
            return FactorialNumber * Factorial(FactorialNumber - 1);
        }
    }
}
