using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Car : Vehicle
    {
        public Car(double fuel, double consumption, int tankCapacity) : base(fuel, consumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            get => base.FuelConsumption;
            protected set { base.FuelConsumption = value + 0.9; }
        }
    }
}
