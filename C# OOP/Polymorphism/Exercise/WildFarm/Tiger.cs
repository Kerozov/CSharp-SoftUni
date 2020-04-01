using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
   public class Tiger:Feline
    {
        public Tiger(string name, double weight, string livingRegion, string bread) : base(name, weight, livingRegion, bread)
        {
        }
        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
        public override void Eat(string type, int quentity)
        {
            if (type != "Meat")
            {
                throw new ArgumentException($"Tiger does not eat {type}!");
            }
            base.Eat(type, quentity);
            this.Weight += 1.00 * quentity;
        }
    }
}
