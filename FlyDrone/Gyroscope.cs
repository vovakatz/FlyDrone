using System;
using static FlyDrone.Enums;

namespace FlyDrone
{
    public class Gyroscope
    {
        private static Gyroscope _instance;
        public delegate void MovementHandler(int x, int y, int z, EventArgs e);
        public event MovementHandler LevelChanged;
        private Gyroscope() { }

        public static Gyroscope Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Gyroscope();
                }
                return _instance;
            }
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
}
