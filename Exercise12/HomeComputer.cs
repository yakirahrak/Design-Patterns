using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class HomeComputer: ComputerBuilder
    {
        public HomeComputer()
        {
            computer = new Computer("home computer");
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
            computer.Proccessor = "fine";
        }

        public override void AddRAM()
        {
            computer.RAM = "good";
        }

        public override void BuildContainer()
        {
            computer.Container = "amazing";
        }

        public override void Test()
        {
            Console.WriteLine("test office");
        }
    }
}
