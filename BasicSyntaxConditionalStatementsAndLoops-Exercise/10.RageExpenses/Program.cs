using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostsCounter = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double budget = 0;

            for (int i = 1; i <= lostsCounter; i++)
            {
                if (i % 2 != 0)
                {

                }
                else
                {
                    budget += headsetPrice;
                }

                if (i % 3 == 0)
                {
                    budget += mousePrice;
                }

                if (i % 6 == 0)
                {
                    budget += keyboardPrice;
                }

                if (i % 12 == 0)
                {
                    budget += displayPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {budget:f2} lv.");

        }
    }
}
