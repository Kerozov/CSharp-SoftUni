using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
   public class Pistol:Gun
   {
       private const int bulletsStrike = 1;
        public Pistol(string name, int bulletsCount) : base(name, bulletsCount)
        {
        }

        public override int Fire()
        {
            this.BulletsCount -= bulletsStrike;
            return bulletsStrike;
        }
    }
}
