using Transport.Entities.Engines;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;

namespace Transport.Entities.Transport
{
    class Car : Vehicle
    {
        public string Manufacturer { get; private set; }

        public string PanoramicViewRoof { get; private set; }

        public Car(Engine engine, CarChassis chassis, Transmission transmission, string manufacturer)
        {
            


        }
    }
}
