using Transport.Enums;

namespace Transport.Entities.Transmissions
{
    public class Mechanical : Transmission
    {
        public Mechanical(int gears, string manufacturer)
        {
            Gears = gears;
            Manufacturer = manufacturer;
            Type = TransmissionTypes.Mechanical;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
