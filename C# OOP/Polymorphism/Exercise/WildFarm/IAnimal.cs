using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        int FoodEaten { get; }
        string ProduceSound();
        void Eat(string type, int quentity);
    }
}
