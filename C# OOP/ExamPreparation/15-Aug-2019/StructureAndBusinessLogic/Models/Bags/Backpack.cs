using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SpaceStation.Models.Bags
{
    public class Backpack : IBag
    {
        private readonly ICollection<string> items;
        public Backpack()
        {
            this.items = new List<string>();
        }
        public ICollection<string> Items { get=>this.items; }
    }
}
