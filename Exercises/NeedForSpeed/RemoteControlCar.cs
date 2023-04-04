using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.NeedForSpeed
{
    class RemoteControlCar
    {
        private int _battery = 100;
        private int _distance;
        private int _speed;
        private int _batteryDrain;

        public RemoteControlCar(int speed, int batteryDrain)
        {
            _speed = speed;
            _batteryDrain = batteryDrain;
        }

        private void Drive(int speed)
        {
            _distance += _speed;
            _battery -= _batteryDrain;
        }

        private int DistanceDriven()
        {
            return _distance;
        }

        private bool BatteryDrained()
        {
            if (_battery > 0)
                return false;
            else
                return true;
        }

        private void Nitro()
        {
            RemoteControlCar nitro = new RemoteControlCar(50, 4);
        }
    }

}
