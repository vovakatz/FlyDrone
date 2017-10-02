using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FlyDrone.Enums;

namespace FlyDrone
{
    public class FlightManager
    {
        private static FlightManager _instance;
        private Drone _drone;

        private FlightManager()
        {
            Init();
        }

        private void Init()
        {
            _drone = new Drone();
            _drone.Engines.Add(new Engine(EngineType.FrontLeft));
            _drone.Engines.Add(new Engine(EngineType.FrontRight));
            _drone.Engines.Add(new Engine(EngineType.RearLeft));
            _drone.Engines.Add(new Engine(EngineType.RearRight));

            Gyroscope.Instance.LevelChanged += LevelChanged;
            _drone.EngineFailed += EngineFailed;

            _drone.StartMonitors();
        }

        private void EngineFailed(EngineType enginType, EventArgs e)
        {
            Console.WriteLine("Failure detected in " + enginType);
        }

        private void LevelChanged(int x, int y, int z, EventArgs e)
        {
            //like in case someone touches the drone
            _drone.Stabilize();
        }

        public static FlightManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FlightManager();
                }
                return _instance;
            }
        }

        public void TakeOff()
        {
            _drone.UpDown(75);
            Console.WriteLine("Taking off");
        }

        public void MoveForward(int power)
        {
            _drone.Forward(power);
            Console.WriteLine("Moving Forward");
        }

        public void MoveBack(int power)
        {
            _drone.Backward(power);
            Console.WriteLine("Moving Backward");
        }

        public void MoveLeft(int power)
        {
            _drone.Left(power);
            Console.WriteLine("Moving Left");
        }

        public void MoveRight(int power)
        {
            _drone.Right(power);
            Console.WriteLine("Moving Right");
        }

        public void MoveUp(int power)
        {
            _drone.UpDown(power);
        }

        public void Movedown(int power)
        {
            _drone.UpDown(power);
            Console.WriteLine("Moving down");
        }

        public void Stabilize()
        {
            _drone.Stabilize();
            Console.WriteLine("Stabilizing");
        }

        public void Land()
        {
            _drone.Land();
            Console.WriteLine("Landing");
        }
    }
}
