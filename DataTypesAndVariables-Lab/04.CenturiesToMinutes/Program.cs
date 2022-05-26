using System;

namespace _04.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422m);
            ulong hrs = days * 24;
            ulong mins = hrs * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hrs} hours = {mins} minutes");
        }
    }
}
