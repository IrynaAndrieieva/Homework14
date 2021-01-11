using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14.Logger
{
    public class Actions
    {      
        private readonly Loger loger = Loger.Instance;

        public void LoggerInfo()
        {
            this.loger.LogMessage("Info", "Start method");
            FileService.WriteLine("Info", "Start method");
        }
    
        public void LoggerError()
        {
            this.loger.LogMessage("Error", "Action failed by reason");
            FileService.WriteLine("Error", "Action failed by reason");         
        }
    }
}
