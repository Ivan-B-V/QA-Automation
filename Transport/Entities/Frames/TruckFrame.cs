

namespace Task3_Transport.Entities.Frames
{
    class TruckFrame : Frame
    {

        public TruckFrame(uint wheelBase, uint payload, string serialNumber)
        {
            WheelBase = wheelBase;
            Payload = payload;
            SerialNumber = serialNumber;
        }
    }
}
