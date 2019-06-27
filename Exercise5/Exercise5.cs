using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Exercise5
    {
        public static void Start()
        {
            LogType logger = new InfoLog();
            logger.Log(consts.LogTypeEnum.error);
        }
    }
}
