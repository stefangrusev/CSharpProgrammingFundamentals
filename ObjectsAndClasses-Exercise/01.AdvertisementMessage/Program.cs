using System;

namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            AdvertisementMessages
                (
                out string[] phrases, 
                out string[] events, 
                out string[] authors, 
                out string[] cities
                );

            int msgs = int.Parse(Console.ReadLine());
            var rnd = new Random();

            Output(phrases, events, authors, cities, msgs, rnd);

        }



        private static void AdvertisementMessages(out string[] phrases, out string[] events, out string[] authors, out string[] cities)
        {
            phrases = new string[]
            {    "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                 "Exceptional product.",
                "I can’t live without this product."
            };
            events = new string[]
            {   "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" 
            };
            authors = new string[]
            {    "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            cities = new string[]
            {    "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
        }



        private static void Output(string[] phrases, string[] events, string[] authors, string[] cities, int msgs, Random rnd)
        {
            for (int i = 0; i < msgs; i++)
            {
                int rndPhrase = rnd.Next(0, phrases.Length - 1);
                int rndEvent = rnd.Next(0, events.Length - 1);
                int rndAuthor = rnd.Next(0, authors.Length - 1);
                int rndCity = rnd.Next(0, cities.Length - 1);
                Console.WriteLine($"{phrases[rndPhrase]} {events[rndEvent]} {authors[rndAuthor]} - {cities[rndCity]}");
            }
        }
    }
}