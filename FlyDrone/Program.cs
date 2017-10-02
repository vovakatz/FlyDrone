using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyDrone
{
    class Program
    {
        static void Main(string[] args)
        {
            var flightControl = FlightManager.Instance;

            flightControl.TakeOff();
            flightControl.MoveForward(100);
            //and so on
        }
    }
}
