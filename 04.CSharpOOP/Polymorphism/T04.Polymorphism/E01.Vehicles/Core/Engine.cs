using System;
using System.Linq;

using E01.Vehicles.Models;
using E01.Vehicles.Factories;
using E01.Vehicles.Core.Contracts;


namespace E01.Vehicles.Core;
public class Engine : IEngine
{

    private VehicleFactory vehicleFactory;

    public Engine()
    {
        this.vehicleFactory = new VehicleFactory();
    }
    public void Run()
    {
        Vehicle car = ProduceVehicle();
        Vehicle truck = ProduceVehicle();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] cmdArs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            try
            {
                ProcessCommand(car, truck, cmdArs);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);

    }

    private static void ProcessCommand(Vehicle car, Vehicle truck, string[] cmdArs)
    {
        string cmdType = cmdArs[0];
        string vehicleType = cmdArs[1];
        double arg = double.Parse(cmdArs[2]);

        if (cmdType == "Drive")
        {
            if (vehicleType == "Car")
            {
                Console.WriteLine(car.Drive(arg));
            }
            else if (vehicleType == "Truck")
            {
                Console.WriteLine(truck.Drive(arg));
            }
        }
        else if (cmdType == "Refuel")
        {
            if (vehicleType == "Car")
            {
                car.Refuel(arg);
            }
            else if (vehicleType == "Truck")
            {
                truck.Refuel(arg);
            }
        }
    }

    private Vehicle ProduceVehicle()
    {
        string[] vehicleArgs = Console.ReadLine()
                            .Split(' ',
                            StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
        string type = vehicleArgs[0];
        double fuelQty = double.Parse(vehicleArgs[1]);
        double fuelConsumption = double.Parse(vehicleArgs[2]);

        Vehicle vehicle = this.vehicleFactory.ProduceVehicle(type, fuelQty, fuelConsumption);

        return vehicle;
    }

}
