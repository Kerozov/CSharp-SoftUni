using System;
using System.Collections.Generic;
using System.Text;

namespace CarEngineandTires
{
    class Tyre
    {
        private int year;
        private double pressure;
        public int Year { get; set; }
        public int Pressure { get; set; }

        public Tyre(int Year, double Pressure)
        {
             this.year= Year;
             this.pressure = Pressure;
        }
    }
}
