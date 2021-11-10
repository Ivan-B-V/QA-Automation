using Transport.Entities.Transmissions;
using Transport.Entities.Engines;
using Transport.Entities.Chassises;

namespace Transport.Entities.Transport
{
    abstract class Transport
    {
        public Engine Engine { get; protected set; }

        public Transmission Transmission { get; protected set; }

        public Chassis Chassis { get; protected set; }

        /*public Transport(Engine engine, Chassis chassis, Transmission transmission)
        {
            
        }*/

        public override string ToString()
        {
            return $"{Engine}\n{Transmission}\n{Chassis}";
        }

    }
}
