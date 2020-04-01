using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
   public class Cat:Feline
    {
        public Cat(string name, double weight, string livingRegion, string bread) : base(name, weight, livingRegion, bread)
        {
        }
        public override string ProduceSound()
        {
            return "Meow";
        }
        public override void Eat(string type, int quentity)
        {
            if (type == "Meat" || type == "Vegetable")
            {
                base.Eat(type, quentity);
                this.Weight += 0.30 * quentity;
                
            }
            else
            {
                throw new ArgumentException($"Cat does not eat {type}!");
            }
         
        }
    }
}
