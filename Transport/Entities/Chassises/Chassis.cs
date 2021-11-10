
namespace Transport.Entities.Chassises
{
    abstract class Chassis
    {
        public uint WheelBase { get; protected set; }

        public uint Payload { get; protected set; }

        public string SerialNumber { get; protected set; }

        public override string ToString()
        {
            return $"WheelBase: {WheelBase}, Payload: {Payload}, SerialNumber: {SerialNumber}";
        }

    }
}
