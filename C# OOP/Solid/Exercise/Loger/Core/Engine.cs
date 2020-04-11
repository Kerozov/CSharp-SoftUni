using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loger.Core.Contract;
using Loger.Factories;
using Loger.Models.Contracts;

namespace Loger.Core
{
    public class Engine:IEngine
    {
        private ILogger logger;
        private ErrorFactory errorFactory;
        public Engine(ILogger logger)
        :this()
        {
            this.logger= logger;
        }

        private Engine()
        {
            errorFactory = new ErrorFactory();
        }
        public void Run()
        {
            string input;
            while ((input = Console.ReadLine())!="END")
            {
                string[] inputArgs = input
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string level = inputArgs[0];
                string dateTime = inputArgs[1];
                string message = inputArgs[2];
                try
                {
                    IError error = this.errorFactory.ProduceError(dateTime, message, level);
                    this.logger.Log(error);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                Console.WriteLine(logger);
            }
        }
    }
}
