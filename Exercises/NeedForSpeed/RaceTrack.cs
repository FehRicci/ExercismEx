using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.NeedForSpeed
{
    class RaceTrack
    {
        private int _distance;

        public RaceTrack(int distance)
        {
            _distance = distance;
        }

        public bool TryFinishTrack(RemoteControlCar controlCar)
        {
            while (!controlCar.BatteryDrained())
            {
                controlCar.Drive();
            }
            if (controlCar.DistanceDriven() > _distance)
                return true;
            else 
                return false;
        }
    }
}
