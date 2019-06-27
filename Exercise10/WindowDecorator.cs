using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public abstract class WindowDecorator:Window
    {
        protected Window window;

        public WindowDecorator(Window window)
        {
            this.window = window;
        }
    }
}
