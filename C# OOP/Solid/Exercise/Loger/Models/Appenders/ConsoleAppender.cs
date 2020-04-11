using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Loger.Models.Contracts;
using Loger.Models.Enumerations;

namespace Loger.Models.Appenders
{
    class ConsoleAppender:IApender
    {
        public ConsoleAppender(ILayout layout,Level level)
        {
            this.Layout = layout;
            this.Level = level;
        }
        public ILayout Layout { get; private set; }
        public Level Level { get; private set; }
        public long MessagesAppend { get; private set; }

        public void Append(IError error)
        {
            string format = Layout.Format;
            DateTime dateTime = error.DateTime;
            string message = error.Message;
            Level level = error.level;
            string formatedMessage =
                string.Format(dateTime.ToString("M/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                    , message,level.ToString());
            Console.WriteLine(formatedMessage);
            this.MessagesAppend++;
        }

        public override string ToString()
        {
            return
                $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Level.ToString().ToUpper()}, Messages appended: {this.MessagesAppend}";
        }
    }
}
