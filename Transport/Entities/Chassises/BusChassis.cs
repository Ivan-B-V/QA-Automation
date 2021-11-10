

namespace Transport.Entities.Chassises
{
    class BusChassis : Chassis
    {
        public BusChassis(uint wheelsNumber, uint payload, string serialNumber)
        {
            if (wheelsNumber < 4)
            {
                throw new System.Exception("Bus cannot has less than 4 wheels.");
            }
            WheelBase = wheelsNumber;
            Payload = payload;
            SerialNumber = serialNumber;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
