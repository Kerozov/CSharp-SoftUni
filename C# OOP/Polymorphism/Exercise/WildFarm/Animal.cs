using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
   public abstract class Animal:IAnimal
    {
        public Animal(string name,double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string Name { get; set; }
        public double Weight { get; set; }
        public virtual int FoodEaten { get; set; }

        public abstract string ProduceSound();

        public virtual void Eat(string type, int quentity)
        {
            this.FoodEaten += quentity;
        }
    }
}
