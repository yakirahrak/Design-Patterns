using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public class Exercise9
    {
        public static void Start()
        {
            CarFactory factory = new NormalCarFactory();
            factory.CreateAC();
        }
    }
}
