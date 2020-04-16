using System;
using System.Text;
using System.Collections.Generic;

namespace CounterStrike.Models
{
    public class Pistol : Gun
    {
        public Pistol(string name, int bulletsCount)
            : base(name, bulletsCount)
        {
        }

        public override int Fire()
        {
            if (this.BulletsCount >= 1)
            {
                this.bulletsCount -= 1;
                return 1;
            }
            return 0;
        }
    }
}
