using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Exercise6
    {
        public static void Start()
        {
            FlyWeightPowerNumber flyWeightPowerNumber = new FlyWeightPowerNumber();
            flyWeightPowerNumber.AddPowerNumber(2, 6);
            flyWeightPowerNumber.AddPowerNumber(3, 3);

            foreach (PowerNumber number in flyWeightPowerNumber.powerNumbers)
            {
                Console.WriteLine(number.CalculateNumber());
            }
        }
    }
}
