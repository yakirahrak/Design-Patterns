using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercise5.consts;

namespace Exercise5
{
    public abstract class LogType
    {
        protected LogType higherLogType;
        public abstract void Log(LogTypeEnum logType);
    }
}
