using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    internal sealed class Loger
    {       
        private static readonly Loger instance = new Loger();
     
        internal static Loger Instance
        {
            get
            {
                return instance;
            }
        }
     
        internal void LogMessage(string typeLog, string message)
        {
            Console.WriteLine("[{0}]: {1}: {2}", DateTime.Now.ToLongTimeString(), typeLog, message);
        }
    }
}
