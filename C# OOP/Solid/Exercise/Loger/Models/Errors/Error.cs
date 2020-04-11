using System;
using System.Collections.Generic;
using System.Text;
using Loger.Models.Contracts;
using Loger.Models.Enumerations;

namespace Loger.Models.Errors
{
    public class Error :IError
    {
        public Error(DateTime dateTime, string message,Level level)
        {
            this.DateTime = dateTime;
            this.level = level;
            this.Message = message;
        }
        public DateTime DateTime { get; private set; }
        public string Message { get; private set; }
        public Level level { get; private set; }
    }
}
