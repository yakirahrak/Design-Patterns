using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class _3DLightning:WindowDecorator
    {
        public _3DLightning(Window window) : base(window)
        {

        }
        public override void DisplayWindow()
        {
            Console.WriteLine("3d");
        }
    }
}
