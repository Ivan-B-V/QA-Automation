using Aircrafts.Interfaces;

namespace Aircrafts.Entities
{
    /// <summary>
    /// Represents Bird instance.
    /// </summary>
    class Bird : IFlyable
    {
 
        private Point3D position;

        private const double maxAltitude = 7;

        private const double maxSpeed = 20;

        private double speed;

        /// <summary>
        /// Posistion property.
        /// </summary>
        ///<value> Property Position represents current bird's position</value> 
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
        /// Speed property.
        /// </summary>
        ///<value> Property Speed represents current bird's speed</value> 
        public double Speed
        {
            get => speed;
            private set => speed = value > maxSpeed ? maxSpeed : value;
        }

        /// <summary>
        /// Max bird's possible altitude.
        /// </summary>
        public double MaxAltitude
        {
            get => maxAltitude;
        }

        /// <summary>
        /// Max bird's speed.
        /// </summary>
        public double MaxSpeed
        {
            get => maxSpeed;
        }

        /// <summary>
        /// Initialise instance of Aircrafts.Entities.Bird class.
        /// </summary>
        /// <param name="point"> Initial bird's posistion. </param>
        public Bird(Point3D point)
        {
            FlyTO(point);
            Speed = (uint)new System.Random().Next((int)maxSpeed);
        }

        /// <exception cref="System.ArgumentNullException"> Throws when point is null. </exception>
        /// <exception cref="System.ArgumentOutOfRangeException"> Throws when point altitude is more than MaxAltitude. </exception>
        public void FlyTO(Point3D point)
        {
            if(point is null)
            {
                throw new System.ArgumentNullException(nameof(point), "Bird cannot flight to the emptiness.");
            }
            if (point.Z > MaxAltitude)
            {
                throw new System.ArgumentOutOfRangeException(nameof(point), $"Max possible bird's altitude is {MaxAltitude}");
            }
            Position = point;
        }

        /// <exception cref="System.ArgumentNullException"> Throws when point is null. </exception>
        /// <exception cref="System.ArgumentOutOfRangeException"> Throws when point altitude is more than MaxAltitude. </exception>
        public double GetFlyTime(Point3D point)
        {
            if (point is null)
            {
                throw new System.ArgumentNullException(nameof(point), "Bird cannot flight to the emptiness.");
            }
            if (point.Z > maxAltitude)
            {
                throw new System.ArgumentOutOfRangeException(nameof(point), $"Max possible bird's altitude is {maxAltitude}");
            }
            double time = Position.Distance(point) / speed;

            return time;
        }
    }
}
