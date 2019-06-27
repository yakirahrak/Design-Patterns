using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public abstract class AbstractPowerNumber
    {
        // Factory method
        public abstract int CalculateNumber();
    }
    public class PowerNumber: AbstractPowerNumber
    {
        public PowerNumber(int p_base, int p_power)
        {
            Base = p_base;
            Power = p_power;
        }
        public int Base { get; set; }
        public int Power { get; set; }

        public override int CalculateNumber()
        {
            return (int)Math.Pow(Base, Power);
        }
    }
}
