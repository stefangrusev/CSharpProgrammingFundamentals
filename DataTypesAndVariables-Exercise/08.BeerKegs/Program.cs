using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string bigName = string.Empty;
            double bigVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                double volume = Math.PI * r * r * h;

                if (volume > bigVolume)
                {
                    bigName = name;
                    bigVolume = volume;
                }
            }

            Console.WriteLine(bigName);
        }
    }
}
