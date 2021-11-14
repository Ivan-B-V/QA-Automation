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
    struct Point3D
    {
        /// <summary>
        /// Store for the X property.
        /// </summary>
        private uint x;

        /// <summary>
        /// Store for the Y property.
        /// </summary>
        private uint y;

        /// <summary>
        /// Store for the Z property.
        /// </summary>
        private uint z;

        /// <summary>
        /// X property.
        /// </summary>
        public uint X
        {
            get => x;
            set => x = value; 
        }

        /// <summary>
        /// Y property.
        /// </summary>
        public uint Y
        {
            get => y;
            set => y = value;
        }

        /// <summary>
        /// Z  property.
        /// </summary>
        public uint Z
        {
            get => z;
            set => z = value;
        }

        /// <summary>
        /// Initializes a new instance of the Aircrafts.Entities.Coordinate3D. class
        /// </summary>
        public Point3D(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// Calculate distance between two coodninates.
        /// </summary>
        /// <param name="point1" name="point2">
        /// The points between which the distance is calculated.
        /// </param>
        /// <returns>
        /// Distance between two coodninates in double format.
        /// </returns>
        public double Distance(Point3D point1, Point3D point2)
        {
            double distance = Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X) +
                                         (point1.Y - point2.Y) * (point1.Y - point2.Y) +
                                         (point1.Z - point2.Z) * (point1.Z - point2.Z));
            return distance;
        }
    }
}
