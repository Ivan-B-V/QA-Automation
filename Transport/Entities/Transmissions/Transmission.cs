using Task3_Transport.Enums;

namespace Task3_Transport.Entities.Powertrains
{
    abstract class Transmission
    {
        
        public string Manufacturer { get; protected set; }

        public int Gears { get; protected set; }

        public TransmissionTypes Type { get; protected set; }

    }
}
