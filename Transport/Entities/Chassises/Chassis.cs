
namespace Transport.Entities.Chassises
{
    public class Chassis
    {
        public uint WheelBase { get; protected set; }

        public uint Payload { get; protected set; }

        public string SerialNumber { get; protected set; }

        public Chassis(uint wheelBase, uint payload, string serialNumber)
        {
            WheelBase =  wheelBase;
            Payload = payload;
            SerialNumber = serialNumber;
        }

        public override string ToString()
        {
            return $"WheelBase: {WheelBase}, Payload: {Payload}, SerialNumber: {SerialNumber}";
        }

    }
}
