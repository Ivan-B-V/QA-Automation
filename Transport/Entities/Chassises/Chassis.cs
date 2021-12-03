
namespace Transport.Entities.Chassises
{
    public class Chassis
    {
        public uint WheelBase { get;  set; }

        public uint Payload { get; set; }

        public string SerialNumber { get;  set; }

        public Chassis() { }

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
