using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class Exercise12
    {
        public static void Start()
        {
            Shop shop = new Shop();
            ComputerBuilder computerBuilder = new GamingComputerBuilder();

            shop.Construct(computerBuilder);
            computerBuilder.Computer.Show();
        }
    }
}
