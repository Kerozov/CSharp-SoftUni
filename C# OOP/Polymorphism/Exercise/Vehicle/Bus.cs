using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Bus : Vehicle
    {
        public Bus(double fuel, double consumption, int tankCapacity) : base(fuel, consumption, tankCapacity)
        {
        }

        public new string Drive(double km,bool isEmpthy)
        {

            if (!isEmpthy)
            {
                base.FuelConsumption += 1.4;
            }               
            var text= base.Drive(km);
            if (!isEmpthy)
            {
                base.FuelConsumption -= 1.4;
            }
            return text;
        }
    }
}
