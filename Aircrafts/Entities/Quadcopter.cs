using System;

namespace Aircrafts.Entities
{
    /// <summary>
    /// Represents quadcopter instance.
    /// </summary>
    class Quadcopter : Drone
    {
        private Point3D position;

        private const double maxAltitude = 11;

        private const double maxSpeed = 120;

        private const double maxFlightTime = 10 /60;

        private const double maxFlightDist = 1000;
        
        private const double chillTime = 1 / 60;

        private double speed;

        /// <summary>
        /// Maximum flight distance.
        /// </summary>
        public double MaxFlightDist
        {
            get => maxFlightDist;
        }

        /// <summary>
        /// Maximum flight speed.
        /// </summary>
        public double MaxSpeed
        {
            get => maxSpeed;
        }

        /// <summary>
        /// Max drone's flight time between without hanging in the air.
        /// </summary>
        public double MaxFlightTime
        {
            get => maxFlightTime;
        }

        /// <summary>
        /// Duration of the required stop.
        /// </summary>
        public double ChillTime
        {
            get => chillTime;
        }

        /// <summary>
        /// Continuous flight speed.
        /// </summary>
        public double Speed
        {
            get => speed;
            set => speed = Math.Abs(value) > maxSpeed ? maxSpeed : Math.Abs(value);
        }
        
        /// <summary>
        /// Current position.
        /// </summary>
        public Point3D Position
        {
            get => position;
            protected set
            {
                if (position.Distance(value) > maxFlightDist)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"Distance between two points should be less than {maxFlightDist}");
                }
                if (value.Z > maxAltitude)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"Max possible drone's altitude is {maxAltitude}");
                }
                position = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Aircrafts.Entities.Quadcopter class.
        /// </summary>
        /// <param name="pos"> Start Quadcopter position. </param>
        public Quadcopter(Point3D pos)
        {
            Position = pos;
            Speed = new Random().NextDouble() * maxSpeed;
        }

        public override void FlyTO(Point3D point)
        {  
            Position = point;
        }

        public override double GetFlyTime(Point3D point)
        {
            double distance = position.Distance(point);
            
            if (position.Distance(point) > maxFlightDist)
            {
                throw new ArgumentOutOfRangeException(nameof(point), $"Distance between two points should be less than {maxFlightDist}");
            }
            if (point.Z > maxAltitude)
            {
                throw new ArgumentOutOfRangeException(nameof(point), $"Max possible drone's altitude is {maxAltitude}");
            }

            int chilloutCount = (int)(distance / (MaxFlightTime * speed));

            double time = chilloutCount * chillTime;
            time += distance / speed;

            return time;
        }
    }
}
