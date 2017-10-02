using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FlyDrone.Enums;

namespace FlyDrone
{
    public class Drone
    {
        public List<Engine> Engines { get; set; }
        public delegate void EngineFailHandler(EngineType engineType, EventArgs e);
        public event EngineFailHandler EngineFailed;

        public Drone()
        {
            Engines = new List<Engine>();
            
        }

        public void StartMonitors()
        {
            MonitorEngineHealth();
        }

        public void UpDown(int power)
        {
            //if power above 50 drone goes up else down.  if 50 then hover
            Parallel.ForEach(Engines, (engine) => engine.Power = power);
        }

        public void Left(int power)
        {
            Parallel.ForEach(Engines, (engine) =>
            {
                if (engine.Type == EngineType.RearRight || engine.Type == EngineType.FrontRight)
                    engine.Power = power;
                else
                    engine.Power = 50;
            });
        }

        public void Right(int power)
        {
            Parallel.ForEach(Engines, (engine) =>
            {
                if (engine.Type == EngineType.RearLeft || engine.Type == EngineType.FrontLeft)
                    engine.Power = power;
                else
                    engine.Power = 50;
            });
        }

        public void Forward(int power)
        {
            Parallel.ForEach(Engines, (engine) =>
            {
                if (engine.Type == EngineType.RearRight || engine.Type == EngineType.RearLeft)
                    engine.Power = power;
                else
                    engine.Power = 50;
            });
        }

        public void Backward(int power)
        {
            Parallel.ForEach(Engines, (engine) =>
            {
                if (engine.Type == EngineType.FrontRight || engine.Type == EngineType.FrontLeft)
                    engine.Power = power;
                else
                    engine.Power = 50;
            });
        }

        public void Stabilize()
        {
            //logic to stabilize goes here
        }

        public void Hover()
        {
            Parallel.ForEach(Engines, (engine) => engine.Power = 50);
        }

        public void Land()
        {
            Parallel.ForEach(Engines, (engine) => engine.Power = 25);
        }

        private void MonitorEngineHealth()
        {
            //logic to monitor engines goes here
            //if failer detected, trigger event like so
            //EngineFailed(EngineType.FrontLeft, null);
        }
    }
}
