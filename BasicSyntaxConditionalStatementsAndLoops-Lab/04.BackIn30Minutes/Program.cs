using System;

namespace _04.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrs = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            mins += 30;

            if (mins > 59)
            {
                mins -= 60;
                hrs++;
            }

            if (hrs == 24)
            {
                hrs = 0;
            }

            Console.WriteLine($"{hrs}:{mins:d2}");

        }
    }
}
