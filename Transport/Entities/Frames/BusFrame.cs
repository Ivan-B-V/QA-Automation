;

namespace Task3_Transport.Entities.Frames
{
    class BusFrame : Frame
    {
        public BusFrame(uint wheelsNumber, uint payload, string serialNumber)
        {
            WheelBase = wheelsNumber;
            Payload = payload;
            SerialNumber = serialNumber;
        }
    }
}
