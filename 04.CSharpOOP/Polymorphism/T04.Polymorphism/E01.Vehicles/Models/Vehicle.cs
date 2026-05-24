using E01.Vehicles.Common;
using E01.Vehicles.Models.Contracts;
using System;


namespace E01.Vehicles.Models;
public abstract class Vehicle : IDriveable, IRefuelable
{
    public Vehicle(double fuelQuantity, double fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;

    }
    public double FuelQuantity { get; private set; }

    //ako e protected set -- moje da se override i da se podmeni stoinostta mu
    public virtual double FuelConsumption { get; protected set; }

    public string Drive(double kilometers)
    {
        double fuelNeeded = kilometers * this.FuelConsumption;

        if (this.FuelQuantity < fuelNeeded)
        {
            string excMsg = String.Format(ExceptionMessages.NotEnoughFuelExceptionMessage, this.GetType().Name);
            throw new InvalidOperationException(excMsg);
        }


        this.FuelQuantity -= fuelNeeded;

        return $"{this.GetType().Name} travelled {kilometers} km";
    }

    public virtual void Refuel(double fuelAmount)
    {
        if (fuelAmount > 0)
        {
            this.FuelQuantity += fuelAmount;
        }

    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}
