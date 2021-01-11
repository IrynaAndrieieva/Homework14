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

        #region tryingMakeInfoAsync

        public void LoggerInfoConslAndFile()
        {
            LoggerInfoAsync();
            FileService.WriteLine("Info", "Start method");
        }
        public async Task LoggerInfoAsync()
        {
            await Task.Run(() => LoggerInfoFromConsl());
        }

        public void LoggerInfoFromConsl()
        {
            this.loger.LogMessage("Info", "Start method");           
        }

        #endregion

      
        #region tryingMakeErrorAsync

        public void LoggerErrorConslAndFile()
        {
            LoggerErrorAsync();
            FileService.WriteLine("Error", "Action failed by reason");
        }
        public async Task LoggerErrorAsync()
        {
            await Task.Run(() => LoggerErrorromConsl());
        }

        public void LoggerErrorromConsl()
        {
            this.loger.LogMessage("Error", "Action failed by reason");
        }

        #endregion
    }
}
