using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loger.Models.Contracts;

namespace Loger.Models
{
    class Logger:ILogger
    {
        private ICollection<IApender> appenders;

        public Logger(ICollection<IApender> appenders)
        {
            this.appenders = appenders;
        }

        public IReadOnlyCollection<IApender> Appenders => (IReadOnlyCollection<IApender>) this.appenders;
        public void Log(IError error)
        {
            foreach (IApender apender in this.appenders)
            {
                if (apender.Level<=error.level)
                {
                   apender.Append(error);
                }
            }
        }

        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
           sb.AppendLine("Loger info:");
           foreach (IApender appender in appenders)
           {
               sb.AppendLine(appender.ToString());
           }

           return sb.ToString().TrimEnd();
        }
    }
}
