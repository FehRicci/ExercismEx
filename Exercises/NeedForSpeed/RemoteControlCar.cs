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
            if (!BatteryDrained())
            {
                _distance += _speed;
                _battery -= _batteryDrain;
            }
            else
            {
                _distance = _distance;
                _battery = _battery;
            }

        }

        public int DistanceDriven()
        {
            return _distance;
        }

        public bool BatteryDrained()
        {
            return !(_battery >= _batteryDrain);
        }

        public static RemoteControlCar Nitro()
        {
            RemoteControlCar nitro = new RemoteControlCar(50, 4);
            return nitro;
        }
    }

}
