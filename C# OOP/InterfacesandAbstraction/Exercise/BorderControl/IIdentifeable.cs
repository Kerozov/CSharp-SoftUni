using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    interface IIdentifeable
    {
        string Id { get; }
        string IsDestryed(string endNumber, string currId);
    }
}
