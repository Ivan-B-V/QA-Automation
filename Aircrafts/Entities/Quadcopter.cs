
namespace Aircrafts.Entities
{
    /// <summary>
    /// Represents Quadcopter instance.
    /// </summary>
    class Quadcopter : Drone
    {
        private Point3D position;

        private double maxAltitude = 11;

        private double maxSpeed = 120;

        private double maxFlightTime = 10 /60;

        private double maxFlightDist = 1000;
        
        private double chillTime = 1 / 60;

        private double speed;

        /// <summary>
        /// Current position.
        /// </summary>
        public Point3D Position
        {
            get => position;
            private set
            {
                if (value.Z > maxAltitude)
                {
                    position = new Point3D(value.X, value.Y, maxAltitude);
                }
            }
        }

        /// <summary>
        /// Maximum quadcopter's possible altitude.
        /// </summary>
        public double MaxAltitude
        {
            get => maxAltitude;
            private set => maxAltitude = value;
        }

        /// <summary>
        /// Maximum flight distance.
        /// </summary>
        public double MaxFlightDist
        {
            get => maxFlightDist;
            private set => maxFlightDist = value;
        }

        /// <summary>
        /// Maximum flight speed.
        /// </summary>
        public double MaxSpeed
        {
            get => maxSpeed;
            private set => maxSpeed = value;
        }

        /// <summary>
        /// Max drone's flight time between without hanging in the air.
        /// </summary>
        public double MaxFlightTime
        {
            get => maxFlightTime;
            private set => maxFlightTime = value;
        }

        /// <summary>
        /// Duration of the required stop.
        /// </summary>
        public double ChillTime
        {
            get => chillTime;
            private set => chillTime = value;
        }

        /// <summary>
        /// Continuous flight speed.
        /// </summary>
        public double Speed
        {
            get => speed;
            set => speed = System.Math.Abs(value) > maxSpeed ? maxSpeed : System.Math.Abs(value);
        }

        /// <summary>
        /// Initializes a new instance of the Aircrafts.Entities.Quadcopter class.
        /// </summary>
        /// <param name="point"> Start Quadcopter position. </param>
        public Quadcopter(Point3D point)
        {
            FlyTO(point);
            Speed = new System.Random().NextDouble() * maxSpeed;
        }

        public override void FlyTO(Point3D point)
        {
            if (point is null)
            {
                throw new System.ArgumentNullException(nameof(point), "Bird cannot flight to the emptiness.");
            }
            if (point.Z > maxAltitude)
            {
                throw new System.ArgumentOutOfRangeException(nameof(point), $"Max possible bird's altitude is {maxAltitude}");
            }
            Position = point;
        }

        /// <summary>
        /// Calculate flying time between two points.
        /// </summary>
        /// <param name="point">
        /// The point to which the flight time is calculated
        /// </param>
        /// <returns>
        /// Returns the flying time to the point in double format.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Throws when point's altitude is more than MaxAltitude or distance between two points more than MaxDistance
        /// </exception>
        /// <exception cref="System.ArgumentNullException"> Throws when point is null. </exception>
        public override double GetFlyTime(Point3D point)
        {
            if (point is null)
            {
                throw new System.ArgumentNullException(nameof(point), "Quadcopter cannot flight to the emptiness.");
            }
            if (point.Z > maxAltitude)
            {
                throw new System.ArgumentOutOfRangeException(nameof(point), $"Max possible quadcopter's altitude is {MaxAltitude}");
            }

            double distance = position.Distance(point);
            
            if (position.Distance(point) > maxFlightDist)
            {
                throw new System.ArgumentOutOfRangeException(nameof(point), $"Distance between two points should be less than {MaxFlightDist}");
            }
           
            int chilloutCount = (int)(distance / (MaxFlightTime * speed));

            double time = chilloutCount * chillTime;
            time += distance / speed;

            return time;
        }
    }
}
