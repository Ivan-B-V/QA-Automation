using System;

namespace Aircrafts.Entities
{
    /// <summary>
    /// Represents the three-dimensional coordinate.
    /// </summary>
    class Point3D
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
            private set => x = Math.Abs(value); 
        }

        /// <summary>
        /// Y property.
        /// </summary>
        public double Y
        {
            get => y;
            private set => y = Math.Abs(value);
        }

        /// <summary>
        /// Z  property.
        /// </summary>
        public double Z
        {
            get => z;
            private set => z = Math.Abs(value);
        }

        /// <summary>
        /// Initializes a new instance of the Aircrafts.Entities.Coordinate3D class. Coordinates X, Y, Z always will be positive.
        /// </summary>
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
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
