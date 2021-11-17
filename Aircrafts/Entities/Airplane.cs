using Aircrafts.Interfaces;
using System;

namespace Aircrafts.Entities
{
    /// <summary>
    /// Represents intance Airplane.
    /// </summary>
    class Airplane : IFlyable
    {
        private Point3D position;

        private double maxAltitude = 11;

        private double maxSpeed = 1100;
        
        private double startSpeed = 200;

        private double acceleration = 10 / 10;
       
        private double speed;

        /// <summary>
        /// Continuous flight speed.
        /// </summary>
        public double Speed
        {
            get => speed;
            protected set => speed = value > maxSpeed ? maxSpeed : value;
        }

        /// <summary>
        /// Current position.
        /// </summary>
        public Point3D Position
        {
            get => position;
            protected set
            {
                if (value.Z > maxAltitude)
                {
                    position = new Point3D(value.X, value.Y, maxAltitude);
                }
                else
                {
                    position = value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the Aircrafts.Entities.Quadcopter class.
        /// </summary>
        /// <param name="position"> Start Airplane position. </param>
        public Airplane(Point3D position)
        {
            Position = position;
            speed = startSpeed;
        }

        public void FlyTO(Point3D point)
        {
            Position = point;
        }

        public double GetFlyTime(Point3D point)
        {
            double distance = Position.Distance(point);

            //Max flying time with acceleration
            double maxAccelTime = (maxSpeed - startSpeed) / acceleration;
            double distWithAccel = startSpeed * maxAccelTime + 0.5 * acceleration * maxAccelTime * maxAccelTime;

            double flyingTime;

            if (distance <= distWithAccel)
            {
                //The solution of the equaiton: S = V0 * t + (a * t^2) / 2
                flyingTime = (-startSpeed + Math.Sqrt(startSpeed * startSpeed + 2 * acceleration * distance)) / acceleration;
            }
            else
            {
                flyingTime = maxAccelTime + (distance - distWithAccel) / maxSpeed;
            }

            return flyingTime;
        }
    }
}
