
namespace Transport.Entities.Chassises
{
    class CarChassis : Chassis
    {
        public CarChassis(uint wheelsNumber, uint payload, string serialNumber)
        {
            if (wheelsNumber < 3)
            {
                throw new System.Exception("Car cannot has less than 4 wheels.");
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
