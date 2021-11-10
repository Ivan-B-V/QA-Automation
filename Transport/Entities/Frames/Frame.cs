
namespace Task3_Transport.Entities.Frames
{
    abstract class Frame
    {
        public uint WheelBase { get; protected set; }

        public uint Payload { get; protected set; }

        public string SerialNumber { get; protected set; }

    }
}
