using System;
using System.Collections.Generic;
using System.Text;

namespace _08_VehicleCatalogue
{
    class Trucks
    {
        public string brand { get; set; }
        public string model { get; set; }
        public string weight { get; set; }
        public Trucks(string Brand, string Model, string Weigth)
        {
            brand = Brand;
            model = Model;
            weight = Weigth;
        }
    }
}
