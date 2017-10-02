using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyDrone
{
    public class Enums
    {
        public enum EngineType
        {
            FrontLeft,
            FrontRight,
            RearLeft,
            RearRight
        }

        public enum EngineStatus
        {
            On,
            Off
        }

        public enum DroneStatus
        {
            Off,
            On,
            Hovering,
            Moving
        }

        public enum MovementDirection
        {
            Left,
            Right,
            Forward,
            Backward,
            Up,
            Down,
            Hover
        }
    }
}
