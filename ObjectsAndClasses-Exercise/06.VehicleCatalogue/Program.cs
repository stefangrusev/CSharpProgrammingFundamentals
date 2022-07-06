using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            string inputCommand = Console.ReadLine();

            while (inputCommand != "End")
            {
                string[] info = inputCommand.Split().ToArray();
                Vehicle vehicle = new Vehicle(info[0], info[1], info[2], double.Parse(info[3]));
                catalogue.Add(vehicle);
                inputCommand = Console.ReadLine();
            }

            inputCommand = Console.ReadLine();
            while (inputCommand != "Close the Catalogue")
            {
                Console.WriteLine(catalogue.First(x => x.Model == inputCommand));
                inputCommand = Console.ReadLine();
            }

            double averageHorsePower = 0;
            var cars = catalogue.Where(x => x.VehicleType == "car");
            if (cars.Count() != 0)
            {
                averageHorsePower = cars.Average(x => x.HorsePower);
            }
            else
            {
                averageHorsePower = 0;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageHorsePower:F2}.");

            var trucks = catalogue.Where(x => x.VehicleType == "truck");
            if (trucks.Count() != 0)
            {
                averageHorsePower = trucks.Average(x => x.HorsePower);
            }
            else
            {
                averageHorsePower = 0;
            }

            Console.WriteLine($"Trucks have average horsepower of: {averageHorsePower:F2}.");
        }
    }

    class Vehicle
    {

        public string VehicleType { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public Vehicle(string vehicleType, string model, string color, double horsePower)
        {
            VehicleType = vehicleType;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Type: {(VehicleType == "car" ? "Car" : "Truck")}");
            output.AppendLine($"Model: {Model}");
            output.AppendLine($"Color: {Color}");
            output.AppendLine($"Horsepower: {HorsePower}");

            return output.ToString().TrimEnd();
        }
    }
}