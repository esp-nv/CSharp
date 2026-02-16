using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RawData
{
    internal class Program
    {
        public class Car
        {
            public string Model { get; set; }

            public Engine Engine { get; set; }
            public Cargo Cargo { get; set; }
            public Car(string model, Engine engine, Cargo cargo)
            {
                Model = model;
                Engine = engine;
                Cargo = cargo;
            }

        }
        public class Engine
        {
            public int Speed { get; set; }
            public int Power { get; set; }
            public Engine(int speed, int power)
            {
                Speed = speed;
                Power = power;
            }
        }
        public class Cargo
        {
            public int Weight { get; set; }
            public string Type { get; set; }
            public Cargo(int weight, string type)
            {
                Weight = weight;
                Type = type;
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
                int speed = int.Parse(parts[1]);
                int power = int.Parse(parts[2]);
                int weight = int.Parse(parts[3]);
                string type = parts[4];
                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(weight, type);
                cars.Add(new Car(model, engine, cargo));
            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == "fragile" && c.Cargo.Weight < 1000))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }

        }
    }
}
