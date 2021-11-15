using Aircrafts.Entities;

namespace Aircrafts.Interfaces
{
    interface IFlyable
    {
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
