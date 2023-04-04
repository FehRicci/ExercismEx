using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.NeedForSpeed
{
    class RemoteControlCar
    {
        private int _battery;
        private int _distance;
        public RemoteControlCar()
        {
            _battery = 100;
            _distance = 0;
        }
        public static RemoteControlCar Buy()
        {
            RemoteControlCar car = new RemoteControlCar();
            return car;
        }
        public void Drive()
        {
            if (_battery > 0)
            {
                _distance += 20;
                _battery -= 1;
            }
        }
        public string DistanceDisplay()
        {
            return "Driven " + _distance + " meters";
        }
        public string BatteryDisplay()
        {
            if (_battery > 0) return "Battery at " + _battery + "%";
            else return "Battery empty";
        }
    }

}
