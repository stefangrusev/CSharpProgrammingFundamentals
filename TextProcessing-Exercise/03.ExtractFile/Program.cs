using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string patch = Console.ReadLine();
            string info = patch.Substring(patch.LastIndexOf('\\') + 1);
            string name = info.Substring(0, info.LastIndexOf('.'));
            string extension = info.Substring(info.LastIndexOf('.') + 1);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}