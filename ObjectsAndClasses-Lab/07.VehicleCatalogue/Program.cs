using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Catalogue carsAndTrucks = new Catalogue();
            carsAndTrucks.Cars = new List<Car>();
            carsAndTrucks.Trucks = new List<Truck>();

            while (input != "end")
            {
                string[] vehicleProps = input.Split('/', StringSplitOptions.RemoveEmptyEntries);
                CarOrTruckCheck(carsAndTrucks, vehicleProps);
                input = Console.ReadLine();
            }

            OutputCheck(carsAndTrucks);
        }




        private static void OutputCheck(Catalogue carsAndTrucks)
        {
            if (carsAndTrucks.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in carsAndTrucks.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (carsAndTrucks.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in carsAndTrucks.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

        private static void CarOrTruckCheck(Catalogue carsAndTrucks, string[] vehicleProps)
        {
            if (vehicleProps[0] == "Car")
            {
                Car car = new Car();
                car.Brand = vehicleProps[1];
                car.Model = vehicleProps[2];
                car.HorsePower = int.Parse(vehicleProps[3]);

                carsAndTrucks.Cars.Add(car);
            }
            else if (vehicleProps[0] == "Truck")
            {
                Truck truck = new Truck();
                truck.Brand = vehicleProps[1];
                truck.Model = vehicleProps[2];
                truck.Weight = int.Parse(vehicleProps[3]);

                carsAndTrucks.Trucks.Add(truck);
            }
        }

        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }


        class Car
        {
            public string Brant { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
            public string Brand { get; internal set; }
        }


        class Catalogue
        {
            public Catalogue()
            {
                this.Cars = Cars;
                this.Trucks = Trucks;
            }
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }
    }
}
