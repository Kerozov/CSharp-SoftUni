using System;
using System.Collections.Generic;
using System.Text;
using Loger.Models;
using Loger.Models.Appenders;
using Loger.Models.Contracts;
using Loger.Models.Enumerations;

namespace Loger.Factories
{
   public class AppenderFactory
   {
       private LayoutFactory layoutFactory;
        public AppenderFactory()
        {
            this.layoutFactory = new LayoutFactory();

        }
        public IApender ProduceAppender(string appenderType,string layoutType, string levelStr)
        {
            Level level;
            bool hasParsed = Enum.TryParse(levelStr, true, out level);
            if (!hasParsed)
            {
                throw new ArgumentException("Invalid level type!");
            }

            ILayout layout = this.layoutFactory.ProduceLayout(layoutType);
            IApender appender;
            if (appenderType=="ConsoleAppender")
            {
                appender = new ConsoleAppender(layout,level);
            }
            else if (appenderType=="FileAppender")
            {
                IFile file = new LogFile("\\data\\","logs.txt");
                appender = new FileAppender(layout,level,file);
            }
            else
            {
                throw new ArgumentException("Invalid appender type!");
            }

            return appender;
        }
    }
}
