using System;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            string spokenLanguage= string.Empty;

            if (countryName == "England" || countryName == "USA")
            {
                spokenLanguage = "English";
            }
            else if (countryName == "Spain" || countryName == "Argentina" || countryName == "Mexico")
            {
                spokenLanguage = "Spanish";
            }
            else
            {
                spokenLanguage = "unknown";
            }

            Console.WriteLine(spokenLanguage);

        }
    }
}
