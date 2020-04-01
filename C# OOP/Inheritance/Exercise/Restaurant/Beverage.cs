﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Restaurant
{
   public class Beverage :Product
    {
        public Beverage(string name, decimal price, double milliliters) : base(name, price)
        {
            Milliliters = milliliters;
        }
     
        public double Milliliters  { get; }
    }
}
