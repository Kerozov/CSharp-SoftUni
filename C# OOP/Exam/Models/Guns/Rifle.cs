using System;
using System.Text;
using System.Collections.Generic;

namespace CounterStrike.Models
{
    public class Rifle : Gun
    {
        public Rifle(string name, int bulletsCount)
            : base(name, bulletsCount)
        {
        }

        public override int Fire()
        {
            if (this.BulletsCount >= 10)
            {
                this.bulletsCount -= 10;
                return 10;
            }

            return 0;
        }
    }
}
