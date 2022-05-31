using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int snow = 0;
            int time = 0;
            int quality = 0;

            BigInteger value = BigInteger.Zero;

            for (int i = 0; i < counter; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                int snowballDivide = snowballSnow / snowballTime;

                BigInteger snowballValue = BigInteger.Pow(snowballDivide, snowballQuality);

                if (snowballValue >= value)
                {
                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;
                    value = snowballValue;
                }
            }

            Console.WriteLine($"{snow} : {time} = {value} ({quality})");
        }
    }
}
