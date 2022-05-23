using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCounter = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double price = 0;

            switch (dayOfTheWeek)
            {
                case "Friday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            price = 8.45;
                            break;
                        case "Business":
                            price = 10.90;
                            break;
                        case "Regular":
                            price = 15;
                            break;
                    }
                    break;
                case "Saturday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            price = 9.80;
                            break;
                        case "Business":
                            price = 15.60;
                            break;
                        case "Regular":
                            price = 20;
                            break;
                    }
                    break;
                case "Sunday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            price = 10.46;
                            break;
                        case "Business":
                            price = 16;
                            break;
                        case "Regular":
                            price = 22.50;
                            break;
                    }
                    break;
            }

            double totalPrice = peopleCounter * price;

            if (peopleCounter >= 30 && typeOfGroup == "Students")
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (peopleCounter >= 100 && typeOfGroup == "Business")
            {
                totalPrice -= (price * 10);
            }
            else if (peopleCounter >= 10 && peopleCounter <= 20 && typeOfGroup == "Regular")
            {
                totalPrice -= totalPrice * 0.05;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
