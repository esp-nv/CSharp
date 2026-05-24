using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01.Vehicles.Models;
public class Car : Vehicle
{

    private const double FUEL_CONSUMPTION_INCREMENT = 0.9;

    public Car(double fuelQuantity, double fuelConsumption) 
        : base(fuelQuantity, fuelConsumption)
    {
    }

    public override double FuelConsumption
    {
        get
        {
            return base.FuelConsumption;
        }
        protected set
        {
            base.FuelConsumption = value + FUEL_CONSUMPTION_INCREMENT;
        }
    }
}
