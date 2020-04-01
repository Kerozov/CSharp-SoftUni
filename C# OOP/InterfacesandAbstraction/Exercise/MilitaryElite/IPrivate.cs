using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
   public interface IPrivate:ISoldier
    {
        decimal Salary { get; }
    }
}
