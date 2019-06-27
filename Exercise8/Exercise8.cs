using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    public class Exercise8
    {
        public static void Start()
        {

            GymPractice a = new RunPractice();
            GymPractice b = new WeightLiftingPractice();

            a.Practice();
            b.Practice();
        }        
    }
}
