using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
   public class PowerMotorcycle :Motorcycle
   {
       private int horsePower;
        public PowerMotorcycle(string model, int horsePower, double cubicCentimeters) : base(model, horsePower, cubicCentimeters)
        {
        }

     public override int HorsePower
     {
         get => this.horsePower;
         private set
         {

         }
     }
        public override double CubicCentimeters { get; set; }
   }
}
