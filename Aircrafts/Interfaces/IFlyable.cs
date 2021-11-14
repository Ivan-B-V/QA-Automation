using Aircrafts.Entities;

namespace Aircrafts.Interfaces
{
    interface IFlyable
    {
        public void FlyTO(Coordinate3D coordinate);

        public uint GetFlyTime(Coordinate3D coordinate);
    }
}
