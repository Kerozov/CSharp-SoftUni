using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Truck : Vehicle
    {
        public Truck(double fuel, double consumption, int tankCapacity) : base(fuel, consumption, tankCapacity)
        {
        }
        public override double FuelConsumption
        {
            get => base.FuelConsumption;
            protected set { base.FuelConsumption = value + 1.6; }
        }

        public override void Reefuel(double fuel)
        {
            if (this.TankCapacity < fuel + FuelQuantity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }
            base.Reefuel(fuel*0.95);
        }

       
    }
}
