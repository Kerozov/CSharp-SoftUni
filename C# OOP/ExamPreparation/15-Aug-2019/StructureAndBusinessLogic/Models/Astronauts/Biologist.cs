﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts
{
    public class Biologist : Astronaut
    {
        public Biologist(string name) : base(name, 70)
        {
        }

        public override void Breath()
        {
            var value = this.Oxygen - 5;
                this.Oxygen -= 5;
           
        }
    }
}
