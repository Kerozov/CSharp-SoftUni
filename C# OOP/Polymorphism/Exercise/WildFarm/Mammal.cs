using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace WildFarm
{
   public abstract class Mammal:Animal
    {
        public string LivingRegion { get; set; }

        protected Mammal(string name, double weight,string livingRegion) : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }
    }
}
