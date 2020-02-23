using System;
using System.Collections.Generic;
using System.Text;

namespace CarEngineandTires
{
    class Engine
    {
        private int horsePower;
        private double cubicCapacity;
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }

        public Engine(int HorsePower, double CubicCapacity)
        {
              horsePower= HorsePower;
              cubicCapacity = CubicCapacity;
        }
    }
}
