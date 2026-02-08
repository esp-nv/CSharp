using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    internal class Program
    {
        public class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
            public Vehicle(string type, string model, string color, int horsePower)
            {
                Type = type;
                Model = model;
                Color = color;
                HorsePower = horsePower;
            }
            
        }
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehicleParts = input.Split(" ");
                string type = vehicleParts[0].ToLower() == "car" ? "Car" : "Truck";
                string model = vehicleParts[1];
                string color = vehicleParts[2];
                int horsePower = int.Parse(vehicleParts[3]);
                
                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                vehicles.Add(vehicle);
            }
            string filterType;
            while ((filterType = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle vehicle = vehicles.FirstOrDefault(v => v.Model == filterType);
                if (vehicle != null)
                {
                    Console.WriteLine($"Type: {vehicle.Type}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                }
            }
            var cars = vehicles.Where(v => v.Type == "Car").ToList();
            var trucks = vehicles.Where(v => v.Type == "Truck").ToList();

            double averageCarHorsePower = cars.Any() ? cars.Average(v => v.HorsePower) : 0.0;
            double averageTruckHorsePower = trucks.Any() ? trucks.Average(v => v.HorsePower) : 0.0;

            Console.WriteLine($"Cars have average horsepower of: {(averageCarHorsePower > 0 ? averageCarHorsePower.ToString("F2") : "0.00")}.");
            Console.WriteLine($"Trucks have average horsepower of: {(averageTruckHorsePower > 0 ? averageTruckHorsePower.ToString("F2") : "0.00")}.");
            
        }
    }
}
