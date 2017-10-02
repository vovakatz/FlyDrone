using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FlyDrone.Enums;

namespace FlyDrone
{
    public class Sensor
    {
        private static Sensor _instance;
        private Sensor() { }

        public static Sensor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Sensor();
                }
                return _instance;
            }
        }

        public int Pitch { get; set; }
        public int Roll { get; set; }
    }
}
