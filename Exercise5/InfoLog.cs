using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercise5.consts;

namespace Exercise5
{
    public class InfoLog : LogType
    {
        public InfoLog()
        {
            higherLogType = new ErrorLog();
        }
        public override void Log(LogTypeEnum logType)
        {
            if((int)logType>(int)LogTypeEnum.info)
            {
                higherLogType.Log(logType);
            }
            else
            {
                Console.WriteLine("log " + logType);
            }
        }
    }
}
