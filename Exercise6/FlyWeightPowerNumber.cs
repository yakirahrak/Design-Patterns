using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class FlyWeightPowerNumber
    {
        public List<PowerNumber> powerNumbers { get; set; } = new List<PowerNumber>();

        public void AddPowerNumber(int p_base, int p_power)
        {
            powerNumbers.Add(new PowerNumber(p_base, p_power));
        }
    }
}
