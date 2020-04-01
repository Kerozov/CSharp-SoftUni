using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    interface IIdentifeable
    {
        string Id { get; }
        string IsDestryed(string endNumber, string currId);
    }
}
