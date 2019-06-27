using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer Computer
        {
            get { return computer; }
        }

        public abstract void BuildContainer();
        public abstract void AddMotherBoard();
        public abstract void AddProccessor();
        public abstract void AddGPU();
        public abstract void AddRAM();
        public abstract void Test();
    }
}
