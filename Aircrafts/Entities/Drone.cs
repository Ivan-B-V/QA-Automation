using Aircrafts.Interfaces;

namespace Aircrafts.Entities
{
    /// <summary>
    /// Represents base behavior and properties intance like a Drone.
    /// </summary>
    abstract class Drone : IFlyable
    {
        public abstract void FlyTO(Point3D point);

        public abstract double GetFlyTime(Point3D point);

    }
}
