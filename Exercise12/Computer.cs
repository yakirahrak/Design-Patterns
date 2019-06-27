using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class Computer
    {
        private string _computerType;
        public string Container { get; set; }
        public string MotherBoard { get; set; }
        public string Proccessor { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }

        public Computer(string computerType)
        {
            _computerType = computerType;
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _computerType);
            Console.WriteLine(" Container : {0}", Container);
            Console.WriteLine(" MotherBoard : {0}", MotherBoard);
            Console.WriteLine(" Proccessor: {0}", Proccessor);
            Console.WriteLine(" GPU : {0}", GPU);
            Console.WriteLine(" RAM : {0}", RAM);
        }
    }
}
