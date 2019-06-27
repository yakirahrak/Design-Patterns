using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercise5.consts;

namespace Exercise5
{
    public class FatalLog : LogType
    {
        public FatalLog()
        {
            higherLogType = new FatalLog();
        }

        public override void Log(LogTypeEnum logType)
        {
            Console.WriteLine("log " + logType);
            WriteToFile();
            SMSHandler.SendSMS();

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
