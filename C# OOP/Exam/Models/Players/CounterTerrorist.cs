﻿using System;
using System.Text;
using System.Collections.Generic;

using CounterStrike.Models.Guns.Contracts;

namespace CounterStrike.Models.Players
{
    public class CounterTerrorist : Player
    {
        public CounterTerrorist(string username, int health, int armor, IGun gun)
            : base(username, health, armor, gun)
        {
        }
    }
}