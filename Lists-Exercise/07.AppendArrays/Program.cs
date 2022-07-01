using System;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var severalArrInputs = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            severalArrInputs.Reverse();
            var theResult = string.Empty;
            foreach (string arrInput in severalArrInputs) { theResult += arrInput + " "; }
            Console.WriteLine(string.Join(" ", theResult.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray()));
        }
    }
}
