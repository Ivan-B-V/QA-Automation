using Transport.Enums;

namespace Transport.Entities.Transmissions
{
    public abstract class Transmission
    {
        
        public string Manufacturer { get;  set; }

        public int Gears { get;  set; }

        public TransmissionTypes Type { get;  set; }

        public Transmission() { }

        public override string ToString()
        {
            return $"TransmisiionType: {Type}, Gears: {Gears}, Manufacturer: {Manufacturer}";
        }
    }   
}
