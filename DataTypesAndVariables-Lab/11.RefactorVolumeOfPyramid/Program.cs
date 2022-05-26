using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtOfThePyramid = double.Parse(Console.ReadLine());
            double widthOfThePyramid = double.Parse(Console.ReadLine());
            double heightOfThePyramid = double.Parse(Console.ReadLine());

            double volumeOfThePyramid = (lenghtOfThePyramid * widthOfThePyramid * heightOfThePyramid) / 3;

            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");

            Console.WriteLine($"Pyramid Volume: {volumeOfThePyramid:f2}");
        }
    }
}
