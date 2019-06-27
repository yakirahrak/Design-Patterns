using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class PartialMirroring:WindowDecorator
    {
        public PartialMirroring(Window window) : base(window)
        {

        }
        public override void DisplayWindow()
        {
            Console.WriteLine("mirror");
        }
    }
}
