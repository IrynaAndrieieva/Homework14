using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    class Logger
    {
        private readonly Logger logger = Logger.Instance;
        private static readonly Logger Instance;

        public void LoggerInfo()
        {
            this.logger.LogMessage("Info", "Start method");
            FileService.WriteLine("Info", "Start method");
        }

        public void LoggerError()
        {
            this.logger.LogMessage("Error", "Action failed by reason");
            FileService.WriteLine("Error", "Action failed by reason");

            try
            {
            }
            catch (Exception)
            {
                Console.WriteLine($"I broke a toilet");
            }
        }

        internal void LogMessage(string typeLog, string message)
        {
            Console.WriteLine("[{0}]: {1}: {2}", DateTime.Now.ToLongTimeString(), typeLog, message);
        }
    }
}
