using Aircrafts.Entities;

namespace Aircrafts.Interfaces
{
    /// <summary>
    /// Interface for classes capable to flight.
    /// </summary>
    interface IFlyable
    {
        /// <summary>
        /// Set up next point of flight.
        /// </summary>
        /// <param name="point">
        /// Next point of flight.
        /// </param>
        public void FlyTO(Point3D point);

        /// <summary>
        /// Calculate flying time between two points.
        /// </summary>
        /// <param name="point">
        /// The point to which the flight time is calculated
        /// </param>
        /// <returns>
        /// Returns the flying time to the point in double format.
        /// </returns>
        public double GetFlyTime(Point3D point);
    }
}
