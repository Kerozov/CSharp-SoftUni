using System;
using System.Collections.Generic;
using System.Text;
using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments.Contracts;

namespace SantaWorkshop.Models.Instruments
{
   public class Instruments :IInstrument
   {
       private int power;

       public Instruments(int power)
       {
           this.Power = power;
       }

        public int Power
        {
            get => this.power;
          private  set { this.power = value > 0 ? value : 0; }
        }

        public void Use()
        {
            this.Power -= 10;
        }
        public bool IsBroken()
        {
            return this.Power == 0;
        }
    }
}
