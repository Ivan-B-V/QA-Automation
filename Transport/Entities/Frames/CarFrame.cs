
namespace Task3_Transport.Entities.Frames
{
    class CarFrame : Frame
    {
        public CarFrame(uint wheelsNumber, uint payload, string serialNumber)
        {
            WheelBase = wheelsNumber;
            Payload = payload;
            SerialNumber = serialNumber;
        }
    }
}
