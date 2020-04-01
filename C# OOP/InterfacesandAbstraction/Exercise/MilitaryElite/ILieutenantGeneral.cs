using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    interface ILieutenantGeneral:IPrivate
    {
        List<string> PrivatesId { get; }
        List<Private> Privates { get; }
    }
}
