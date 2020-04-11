using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using Loger.Models.Contracts;
using Loger.Models.Enumerations;
using Loger.Models.Errors;

namespace Loger.Factories
{
    public class ErrorFactory
    {
        private const string DATE_FORMAT = "M/dd/yyyy h:mm:ss tt";
        public IError ProduceError(string date,string message,string levelStr)
        {
            DateTime dateTime;
            try
            {
                dateTime = DateTime.ParseExact(date, DATE_FORMAT, CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {
                throw new ArgumentException("Invalid date format!",e);
            }

            Level level;
            bool hasPassed = Enum.TryParse<Level>(levelStr, true, out level);
            if (!hasPassed)
            {
                throw  new ArgumentException("Invalid level type!");
            }
            Error error = new Error(dateTime,message,level);
            return error;
        }
    }
}
