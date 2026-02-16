using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SpeedRacing
{
    internal class Program
    {
        public class Car
        {
            public string Model { get; set; }
            public double FuelAmount { get; set; }
            public double FuelConsumptionPerKilometer { get; set; }
            public double DistanceTraveled { get; set; }

            public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
            {
                Model = model;
                FuelAmount = fuelAmount;
                FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
                DistanceTraveled = 0;
            }

            public bool Drive(double distance)
            {
                double requiredFuel = distance * FuelConsumptionPerKilometer;

                if (requiredFuel <= FuelAmount)
                {
                    FuelAmount -= requiredFuel;
                    DistanceTraveled += distance;
                    return true;
                }
                return false;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = parts[0];
                double fuelAmount = double.Parse(parts[1]);
                double fuelConsumptionPerKilometer = double.Parse(parts[2]);

                cars.Add(new Car(model, fuelAmount, fuelConsumptionPerKilometer));
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] parts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = parts[1];
                double distance = double.Parse(parts[2]);

                Car car = cars.FirstOrDefault(c => c.Model == model);

                if (car != null)
                {
                    if (!car.Drive(distance))
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
            }
        }
    }
}
