using System;
using System.Collections.Generic;
using System.Text;
using Loger.Models.Enumerations;

namespace Loger.Models.Contracts
{
    public interface IError
    {
        DateTime DateTime { get; }
        string Message { get; }
        Level level { get; }
    }
}
