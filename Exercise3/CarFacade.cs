using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class CarFacade
    {
        private InfoCar _info;
        private ControlCar _control;

        public CarFacade()
        {
            _info = new InfoCar();
            _control = new ControlCar();
        }

        public void StartDrive()
        {
            _control.StartDrive();
        }

        public void EndDrive()
        {
            _control.EndDrive();
        }

        public void IncreaseSpeed()
        {
            _control.IncreaseSpeed();
        }

        public void DecreaseSpeed()
        {
            _control.DecreaseSpeed();
        }

        public void TurnLeft()
        {
            _control.TurnLeft();
        }

        public void TurnRight()
        {
            _control.TurnRight();
        }

        public void ShowFuel()
        {
            _info.ShowFuel();
        }

        public void ShowLocation()
        {
            _info.ShowLocation();
        }
    }
}
