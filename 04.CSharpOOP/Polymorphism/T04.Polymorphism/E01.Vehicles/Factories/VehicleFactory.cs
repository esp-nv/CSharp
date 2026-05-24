using E01.Vehicles.Common;
using E01.Vehicles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01.Vehicles.Factories;
public class VehicleFactory
{
    public Vehicle ProduceVehicle(string type, double fuelQty, double fuelConsumption)
    {
        Vehicle vehicle = null;

        if (type == "Car")
        {
            vehicle = new Car(fuelQty,fuelConsumption);
        }
        else if (type == "Truck")
        {
            vehicle = new Truck(fuelQty, fuelConsumption);
        }

        if (type == null)
        {
            throw new ArgumentException(ExceptionMessages.InvalidTypeExceptionMessage);
        }

        return vehicle;
    }
}
