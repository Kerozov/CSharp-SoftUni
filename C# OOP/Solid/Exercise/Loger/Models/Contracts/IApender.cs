using System;
using System.Collections.Generic;
using System.Text;
using Loger.Models.Enumerations;

namespace Loger.Models.Contracts
{
   public interface IApender
    {
        ILayout Layout { get; }
        Level Level { get; }
        long MessagesAppend { get; }
        void Append(IError error);
    }
}
