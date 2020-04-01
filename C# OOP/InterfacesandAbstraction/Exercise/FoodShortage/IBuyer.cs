using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    interface IBuyer
    {
        void BuyFood(string name);
        int Food { get; }
    }
}
