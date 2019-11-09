using System;
using System.Collections.Generic;
using System.Text;

namespace _08_VehicleCatalogue
{
    class Car
    {
        public Car(string Brand, string Model, string Weigth)
        {
            brand = Brand;
            model = Model;
            horsePower = Weigth;
        }
        public string brand { get; set; }
        public string model { get; set; }
        public string horsePower { get; set; }
    }
}
