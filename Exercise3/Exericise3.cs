using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Exericise3
    {
        public static void start()
        {
            ICarProxy c = new CarProxy();
            c.ShowCarFuel();
        }
    }
}
