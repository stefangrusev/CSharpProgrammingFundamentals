using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int theFirstNumberToOperateWith = int.Parse(Console.ReadLine());
            char theOperatorBetweenNumbers = char.Parse(Console.ReadLine());
            int theSecondNumberToOperateWith = int.Parse(Console.ReadLine());

            Console.WriteLine(calculationsBetweenTheNumbers(theFirstNumberToOperateWith, theOperatorBetweenNumbers, theSecondNumberToOperateWith));

            static int calculationsBetweenTheNumbers(int theFirstNumberToOperateWith, char theOperatorBetweenNumbers, int theSecondNumberToOperateWith)
            {
                int theResult = 0;
                switch (theOperatorBetweenNumbers)
                {
                    case '/':
                        theResult = theFirstNumberToOperateWith / theSecondNumberToOperateWith;
                        break;
                    case '*':
                        theResult = theFirstNumberToOperateWith * theSecondNumberToOperateWith;
                        break;
                    case '+':
                        theResult = theFirstNumberToOperateWith + theSecondNumberToOperateWith;
                        break;
                    case '-':
                        theResult = theFirstNumberToOperateWith - theSecondNumberToOperateWith;
                        break;
                }
                return theResult;
            }
        }
    }
}
