using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using MXGP.Models.Motorcycles.Contracts;
using MXGP.Utilities.Messages;

namespace MXGP.Models.Motorcycles
{
   public abstract class Motorcycle :IMotorcycle
   {
       private string model;

       protected Motorcycle(string model, int horsePower, double cubicCentimeters)
       {
           this.Model = model;
           this.CubicCentimeters = cubicCentimeters;
           this.HorsePower = horsePower;
       }

        public string Model
        {
            get => this.model;
            private set
            {
                if (String.IsNullOrWhiteSpace(value)||value.Length<4)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidModel,value));
                }

                this.model = value;
            }
        }
        public virtual  int HorsePower { get; set; }
        public abstract double CubicCentimeters { get; set; }
        public double CalculateRacePoints(int laps)
        {
            return this.CubicCentimeters / this.HorsePower * laps;
        }
    }
}
