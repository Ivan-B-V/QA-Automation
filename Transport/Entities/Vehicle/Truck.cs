using Transport.Entities.Engines;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;
using Transport.Enums;

namespace Transport.Entities.Vehicle
{
    class Truck : Vehicle
    {

        public uint MaxTrailerWeight { get; private set; }
        
        public Truck(Engine engine, TruckChassis chassis, Transmission transmission, string manufacturer, uint maxTrailerWeight) :
            base(engine, chassis, transmission, manufacturer)
        {
            MaxTrailerWeight = maxTrailerWeight;
        }

        public override string ToString()
        {
            return $"Max trailer weight: {MaxTrailerWeight}\n{base.ToString()}";
        }
    }
}
