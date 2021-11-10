

namespace Transport.Entities.Chassises
{
    class ScooterChassis : Chassis
    {
        public ScooterChassis(uint payload, string serialNumber)
        {
            WheelBase = 2;
            Payload = payload;
            SerialNumber = serialNumber;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
