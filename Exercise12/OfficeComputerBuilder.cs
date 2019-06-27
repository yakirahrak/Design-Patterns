using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class OfficeComputerBuilder: ComputerBuilder
    {
        public OfficeComputerBuilder()
        {
            computer = new Computer("office computer");
        }

        public override void AddGPU()
        {
            computer.GPU = "fine";
        }

        public override void AddMotherBoard()
        {
            computer.MotherBoard = "fine";
        }

        public override void AddProccessor()
        {
            computer.Proccessor = "fine";
        }

        public override void AddRAM()
        {
            computer.RAM = "fine";
        }

        public override void BuildContainer()
        {
            computer.Container = "nice";
        }

        public override void Test()
        {
            Console.WriteLine("test office");
        }
    }
}
