using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FlyDrone.Enums;

namespace FlyDrone
{
    public class Engine
    {
        public EngineType Type { get; set; } 

        public int Power { get; set; }

        public EngineStatus Status
        {
            get
            {
                if (Power == 0)
                    return EngineStatus.Off;
                return EngineStatus.On;
            }
        }

        public Engine(EngineType engineType)
        {
            Type = engineType;
        }
    }
}
