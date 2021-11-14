using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircrafts.Entities
{
    /// <summary>
    /// Represents the three-dimensional coordinate.
    /// </summary>
    class Coordinate3D
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
            get { return x; }
            set { x = value; }
        }

        /// <summary>
        /// Y property.
        /// </summary>
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        /// <summary>
        /// Z  property.
        /// </summary>
        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        /// <summary>
        /// Initializes a new instance of the Aircrafts.Entities.Coordinate3D. class
        /// </summary>
        public Coordinate3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Calculate distance between two coodninates.
        /// </summary>
        /// <param name="coordinate">
        /// The coordinate to which to calculate the distance.
        /// </param>
        /// <returns>
        /// Distance between two coodninates.
        /// </returns>
        public double Distance(Coordinate3D coordinate1, Coordinate3D coordinate2)
        {
            double distance = Math.Sqrt((coordinate1.X - coordinate2.X) * (coordinate1.X - coordinate2.X) +
                                         (coordinate1.Y - coordinate2.Y) * (coordinate1.Y - coordinate2.Y) +
                                         (coordinate1.Z - coordinate2.Z) * (coordinate1.Z - coordinate2.Z));
            return distance;
        }
    }
}
