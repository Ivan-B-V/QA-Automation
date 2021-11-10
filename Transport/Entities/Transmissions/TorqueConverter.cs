using Task3_Transport.Enums;

namespace Task3_Transport.Entities.Powertrains
{
    class TorqueConverter : Transmission
    {
        public TorqueConverter(int gears, string manufacturer)
        {
            Gears = gears;
            Manufacturer = manufacturer;
            Type = TransmissionTypes.TorqueConverter;
        }
    }
}
