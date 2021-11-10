using Task3_Transport.Entities.Powertrains;
using Task3_Transport.Entities.Engines;
using Task3_Transport.Entities.Frames;

namespace Task3_Transport.Entities.Transport
{
    abstract class Transport
    {
        public Transmission Transmission { get; protected set; }

        public Engine Engine { get; protected set; }

        public Frame Frame { get; protected set; }

    }
}
