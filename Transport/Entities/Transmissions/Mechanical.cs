using Task3_Transport.Enums;

namespace Task3_Transport.Entities.Powertrains
{
    class Mechanical : Transmission
    {
        public Mechanical(int gears, string manufacturer)
        {
            Gears = gears;
            Manufacturer = manufacturer;
            Type = TransmissionTypes.Mechanical;
        }
    }
}
