using Transport.Enums;

namespace Transport.Entities.Transmissions
{
    abstract class Transmission
    {
        
        public string Manufacturer { get; protected set; }

        public int Gears { get; protected set; }

        public TransmissionTypes Type { get; protected set; }

        public override string ToString()
        {
            return $"TransmisiionType: {Type}, Gears: {Gears}, Manufacturer: {Manufacturer}";
        }
    }   
}
