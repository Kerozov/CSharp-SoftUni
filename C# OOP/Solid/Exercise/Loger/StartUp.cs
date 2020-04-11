using System;
using System.Collections.Generic;
using System.Linq;
using Loger.Core;
using Loger.Core.Contract;
using Loger.Factories;
using Loger.Models;
using Loger.Models.Contracts;

namespace Loger
{
  public  class StartUp
    {
       public static void Main(string[] args)
       {
           int appenderCount = int.Parse(Console.ReadLine());
           ICollection<IApender> appenders = new List<IApender>();

           ParseAppenersInput(appenderCount, appenders);
           ILogger logger = new Logger(appenders);

           IEngine engine = new Engine(logger);
           engine.Run();
        }

       private static void ParseAppenersInput(int appenderCount, ICollection<IApender> appenders)
       {
           AppenderFactory appenderFactory = new AppenderFactory();

           for (int i = 0; i < appenderCount; i++)
           {
               var appendersArgs = Console.ReadLine()
                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();
               string appenderType = appendersArgs[0];
               string layoutType = appendersArgs[1];
               string level = "INFO";
               if (appendersArgs.Length == 3)
               {
                   level = appendersArgs[2];
               }

               try
               {
                   IApender appender = appenderFactory.ProduceAppender(appenderType, layoutType, level);
                   appenders.Add(appender);
               }
               catch (ArgumentException ae)
               {
                   Console.WriteLine(ae.Message);
               }

           }
       }
    }
}
