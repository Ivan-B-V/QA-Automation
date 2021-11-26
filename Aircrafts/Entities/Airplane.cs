using Aircrafts.Interfaces;

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

        private double takeoffSpeed = 200;

        private double acceleration = 10 / 10;

        private double speed;

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
        /// Max plane's possible altitude.
        /// </summary>
        public double MaxAltitude
        {
            get => maxAltitude;
            private set => maxAltitude = value;
        }

        /// <summary>
        /// Max plane's speed.
        /// </summary>
        public double MaxSpeed
        {
            get => maxSpeed;
            private set => maxSpeed = value;
        }

        /// <summary>
        /// Takeoff plane's speed.
        /// </summary>
        public double TakeoffSpeed
        {
            get => takeoffSpeed;
            private set => takeoffSpeed = value;
        }

        /// <summary>
        /// Plane's acceleration.
        /// </summary>
        public double Acceleration
        {
            get => acceleration;
            private set => acceleration = value;
        }

        /// <summary>
        /// Continuous flight speed.
        /// </summary>
        public double Speed
        {
            get => speed;
            protected set => speed = value > maxSpeed ? maxSpeed : value;
        }

        /// <summary>
        /// Initializes a new instance of the Aircrafts.Entities.Airplane class.
        /// </summary>
        /// <param name="point"> Start Airplane position. </param>
        public Airplane(Point3D point)
        {
            FlyTO(point);
            speed = takeoffSpeed;
        }

        /// <exception cref="System.ArgumentNullException"> Throws when point is null. </exception>
        /// <exception cref="System.ArgumentOutOfRangeException"> Throws when point altitude is more than MaxAltitude. </exception>
        public void FlyTO(Point3D point)
        {
            if (position is null)
            {
                throw new System.ArgumentNullException(nameof(position), "Airplane should has intial posistion.");
            }
            if (point.Z > maxAltitude)
            {
                throw new System.ArgumentOutOfRangeException(nameof(point), $"Max possible airplane's altitude is {maxAltitude}");
            }

            Position = point;
        }

        /// <exception cref="System.ArgumentNullException"> Throws when point is null. </exception>
        /// <exception cref="System.ArgumentOutOfRangeException"> Throws when point altitude is more than MaxAltitude. </exception>
        public double GetFlyTime(Point3D point)
        {
            if (position is null)
            {
                throw new System.ArgumentNullException(nameof(point), "Airplane cannot flight to the emptiness.");
            }
            if (point.Z > MaxAltitude)
            {
                throw new System.ArgumentOutOfRangeException(nameof(point), $"Max possible airplane's altitude is {MaxAltitude}");
            }

            double distance = Position.Distance(point);

            //Max flying time with acceleration
            double maxAccelTime = (maxSpeed - takeoffSpeed) / acceleration;
            double distWithAccel = takeoffSpeed * maxAccelTime + 0.5 * acceleration * maxAccelTime * maxAccelTime;

            double flyingTime;

            if (distance <= distWithAccel)
            {
                //The solution of the equaiton: S = V0 * t + (a * t^2) / 2
                flyingTime = (-takeoffSpeed + System.Math.Sqrt(takeoffSpeed * takeoffSpeed + 2 * acceleration * distance)) / acceleration;
            }
            else
            {
                flyingTime = maxAccelTime + (distance - distWithAccel) / maxSpeed;
            }

            return flyingTime;
        }
    }
}
