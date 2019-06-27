using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public class Exercise10
    {
        public static void Start()
        {
            Window basic = new BasicWindow();
            basic.DisplayWindow();

            basic = new BlinkingBackground(basic);

            basic = new _3DLightning(basic);
        }
    }
}
