

namespace Task3_Transport.Entities.Frames
{
    class ScooterFrame : Frame
    {
        public ScooterFrame(uint payload, string serialNumber)
        {
            WheelBase = 2;
            Payload = payload;
            SerialNumber = serialNumber;
        }
    }
}
