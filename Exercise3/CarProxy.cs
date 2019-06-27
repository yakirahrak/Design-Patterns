using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public abstract class ICarProxy
    {
        public abstract void ShowCarFuel();
        public abstract void ShowCarLoc();
    }
    public class CarProxy : ICarProxy
    {
        private CarFacade _car;
        public CarProxy()
        {
            _car = new CarFacade();
        }
        public override void ShowCarFuel()
        {
            _car.ShowFuel();
        }

        public override void ShowCarLoc()
        {
            _car.ShowLocation();
        }
    }
}
