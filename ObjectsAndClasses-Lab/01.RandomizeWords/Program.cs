using System;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var incomingSentance = Console.ReadLine().Split(' ');
            for (var i = 0; i < incomingSentance.Length; i++)
            {
                Random rnd = new Random(); //one instance of Random;
                var randomIndex = rnd.Next(0, incomingSentance.Length); //int
                var word = incomingSentance[i]; //string
                incomingSentance[i] = incomingSentance[randomIndex]; 
                incomingSentance[randomIndex] = word;
            }
            foreach (var word in incomingSentance) { Console.WriteLine(word); }
        }
    }
}
