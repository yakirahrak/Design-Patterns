using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercise5.consts;

namespace Exercise5
{
    public class ErrorLog:LogType
    {
        public ErrorLog()
        {
            higherLogType = new FatalLog();
        }

        public override void Log(LogTypeEnum logType)
        {
            if ((int)logType > (int)LogTypeEnum.error)
            {
                higherLogType.Log(logType);
            }
            else
            {
                Console.WriteLine("log " + logType);
                WriteToFile();
            }
        }

        private void WriteToFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt"))
            {
                file.WriteLine("log");
            }
        }
    }
}
