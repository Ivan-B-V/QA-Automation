using Aircrafts.Entities;

namespace Aircrafts.Interfaces
{
    interface IFlyable
    {
        public void FlyTO(Point3D point);

        public uint GetFlyTime(Point3D point);
    }
}
