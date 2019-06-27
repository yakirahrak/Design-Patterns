using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class GamingComputerBuilder : ComputerBuilder
    {
        public GamingComputerBuilder()
        {
            computer = new Computer("Gaming computer");
        }
        public override void AddGPU()
        {
            computer.GPU = "good";
        }

        public override void AddMotherBoard()
        {
            computer.MotherBoard = "good";
        }

        public override void AddProccessor()
        {
            computer.Proccessor = "good";
        }

        public override void AddRAM()
        {
            computer.RAM = "good";
        }

        public override void BuildContainer()
        {
            computer.Container = "ugly";
        }

        public override void Test()
        {
            Console.WriteLine("test gaming");
        }
    }
}
