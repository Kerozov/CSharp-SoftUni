using System;
using System.Collections.Generic;
using System.Text;

namespace Loger.Models.Contracts
{
   public interface ILogger
    {
        IReadOnlyCollection<IApender> Appenders { get; }
        void Log(IError error); 
    }
}
