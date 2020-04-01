using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ISpecialisedSoldier:IPrivate
    {
        string Corps { get; }
    }
}
