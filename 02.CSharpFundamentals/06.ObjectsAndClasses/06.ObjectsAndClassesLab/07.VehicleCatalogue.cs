using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    internal class Program
    {

        public class Cars
        {
            public string BrandCars { get; set; }
            public string ModelCars { get; set; }
            public int HorsePower { get; set; }

            public Cars()
            {
                BrandCars = string.Empty;
                ModelCars = string.Empty;
                HorsePower = 0;
            }

            public override string ToString()
            {
                return $"{BrandCars}: {ModelCars} - {HorsePower}hp";
            }
        }

        public class Trucks
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }

            public Trucks()
            {
                Brand = string.Empty;
                Model = string.Empty;
                Weight = 0;
            }

            public override string ToString()
            {
                return $"{Brand}: {Model} - {Weight}kg";
            }
        }
        public class VehicleCatalogue
        {
            public List<Cars> CarsList { get; set; }
            public List<Trucks> TrucksList { get; set; }

            public VehicleCatalogue()
            {
                CarsList = new List<Cars>();
                TrucksList = new List<Trucks>();
            }
        }

        static void Main(string[] args)
        {
            VehicleCatalogue vehicleCatalogue = new VehicleCatalogue();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] vehicleInfo = input.Split('/');

                if (vehicleInfo[0] == "Car")
                {
                    Cars car = new Cars
                    {
                        BrandCars = vehicleInfo[1],
                        ModelCars = vehicleInfo[2],
                        HorsePower = int.Parse(vehicleInfo[3])
                    };
                    vehicleCatalogue.CarsList.Add(car);
                }
                else if (vehicleInfo[0] == "Truck")
                {
                    Trucks truck = new Trucks
                    {
                        Brand = vehicleInfo[1],
                        Model = vehicleInfo[2],
                        Weight = int.Parse(vehicleInfo[3])
                    };

                    vehicleCatalogue.TrucksList.Add(truck);
                }
            }

            Cars[] sortedCars = vehicleCatalogue.CarsList.OrderBy(c => c.BrandCars).ToArray();

            Trucks[] sortedTrucks = vehicleCatalogue.TrucksList.OrderBy(t => t.Brand).ToArray();

            if (sortedCars.Length > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in sortedCars)
                {
                    Console.WriteLine(car);
                }
            }

            if (sortedTrucks.Length > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (var truck in sortedTrucks)
                {
                    Console.WriteLine(truck);
                }
            }
        }
    }
}
