using System;
using Aircrafts.Interfaces;

namespace Aircrafts.Entities
{
    class Bird : IFlyable
    {
        public Point3D position;
        private double maxSpeed = 20;
        private double speed;
        private double maxAltitude = 7;

        public double Speed
        {
            get => speed;
            protected set => speed = value > maxSpeed ? maxSpeed : value;
        }

        public Point3D Position
        {
            get => position;
            protected set 
            {
                if (value.Z > maxAltitude)
                {
                    position = new Point3D(value.X, value.Y, maxAltitude);
                }
            }
        }

        public Bird(Point3D position)
        {
            Position = position;
            Speed = (uint)new Random().Next((int)maxSpeed);
        }

        public void FlyTO(Point3D point)
        {
            Position = point;
        }

        public double GetFlyTime(Point3D point)
        {
            double time = Position.Distance(point) / speed;

            return time;
        }
    }
}
