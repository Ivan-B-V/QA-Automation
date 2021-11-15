using System;

namespace Aircrafts.Entities
{
    /// <summary>
    /// Represents the three-dimensional coordinate.
    /// </summary>
    struct Point3D
    {
        /// <summary>
        /// Store for the X property.
        /// </summary>
        private double x;

        /// <summary>
        /// Store for the Y property.
        /// </summary>
        private double y;

        /// <summary>
        /// Store for the Z property.
        /// </summary>
        private double z;

        /// <summary>
        /// X property.
        /// </summary>
        public double X
        {
            get => x;
            private set => x = value < 0 ? 0 : value; 
        }

        /// <summary>
        /// Y property.
        /// </summary>
        public double Y
        {
            get => y;
            private set => y = value < 0 ? 0 : value;
        }

        /// <summary>
        /// Z  property.
        /// </summary>
        public double Z
        {
            get => z;
            private set => z = value < 0 ? 0 : value;
        }

        /// <summary>
        /// Initializes a new instance of the Aircrafts.Entities.Coordinate3D. class
        /// </summary>
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// Calculate distance between two coodninates.
        /// </summary>
        /// <param name="point">
        /// The point to which the distance is calculated.
        /// </param>
        /// <returns>
        /// Distance between two coodninates in double format.
        /// </returns>
        public double Distance(Point3D point)
        {
            double distance = Math.Sqrt((X - point.X) * (X - point.X) +
                                         (Y - point.Y) * (Y - point.Y) +
                                         (Z - point.Z) * (Z - point.Z));
            return distance;
        }
    }
}
