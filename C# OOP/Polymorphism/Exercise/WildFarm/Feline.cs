using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace WildFarm
{
   public abstract class Feline:Mammal
    {
        protected Feline(string name, double weight, string livingRegion, string bread) : base(name, weight, livingRegion)
        {
            this.Breed = bread;
        }
        public string Breed { get; set; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
