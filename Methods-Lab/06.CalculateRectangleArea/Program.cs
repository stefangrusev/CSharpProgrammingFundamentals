using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthOfTheRectangle = int.Parse(Console.ReadLine());
            int heightOfTheRectangle = int.Parse(Console.ReadLine());
            int area = TheAreaOfTheRectangle(widthOfTheRectangle, heightOfTheRectangle);
            Console.WriteLine(area);
        }
        static int TheAreaOfTheRectangle(int widthOfTheRectangle, int heightOfTheRectangle)
        {
            int theAreaIs = heightOfTheRectangle * widthOfTheRectangle;
            return theAreaIs;
        }
    }
}
