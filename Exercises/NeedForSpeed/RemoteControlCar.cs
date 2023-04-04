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

        public void Drive()
        {
            _distance += _speed;
            _battery -= _batteryDrain;
        }

        public int DistanceDriven()
        {
            return _distance;
        }

        public bool BatteryDrained()
        {
            if (_battery > 0)
                return false;
            else
                return true;
        }

        public void Nitro()
        {
            RemoteControlCar nitro = new RemoteControlCar(50, 4);
        }
    }

}
