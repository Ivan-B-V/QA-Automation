using Transport.Entities.Engines;
using Transport.Entities.Chassises;
using Transport.Entities.Transmissions;
using Transport.Enums;

namespace Transport.Entities.Vehicle
{
    class Car : Vehicle
    {
        public CarTypes CarType { get; private set; }

        public Car(Engine engine, CarChassis chassis, Transmission transmission, string manufacturer, CarTypes carType) :
            base(engine, chassis, transmission, manufacturer)
        {
            this.CarType = carType;
        }

        public override string ToString()
        {
            return $"Car type: {CarType}\n{base.ToString()}";
        }
    }
}
