using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class Shop

    {
        public void Construct(ComputerBuilder computerBuilder)
        {
            computerBuilder.BuildContainer();
            computerBuilder.AddMotherBoard();
            computerBuilder.AddProccessor();
            computerBuilder.AddGPU();
            computerBuilder.AddRAM();
            computerBuilder.Test();
        }
    }
}
