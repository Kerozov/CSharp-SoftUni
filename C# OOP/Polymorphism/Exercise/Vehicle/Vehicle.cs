using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    public class Vehicle
    {
        private double fuelQuantity;
        public int TankCapacity { get; protected set; }
        public Vehicle(double fuel, double consumption, int tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuel;
            this.FuelConsumption = consumption;
        }
        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                fuelQuantity = value;
            }
        }
        public virtual double FuelConsumption { get; protected set; }

        public virtual string Drive(double km)
        {
            double fuelNeeded = km * this.FuelConsumption;
            if (fuelNeeded > FuelQuantity)
            {
                throw new ArgumentException(String.Format("{0} needs refueling", this.GetType().Name));
            }

            this.FuelQuantity -= fuelNeeded;
            return string.Format("{0} travelled {1} km", this.GetType().Name, km);
        }

        public virtual void Reefuel(double fuel)
        {
           
            if (this.TankCapacity < fuel + fuelQuantity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
