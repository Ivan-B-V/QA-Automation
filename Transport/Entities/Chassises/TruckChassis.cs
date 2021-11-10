

namespace Transport.Entities.Chassises
{
    class TruckChassis : Chassis
    {

        public TruckChassis(uint wheelsNumber, uint payload, string serialNumber)
        {
            if (wheelsNumber < 4)
            {
                throw new System.Exception("Truck cannot has less than 4 wheels.");  
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
